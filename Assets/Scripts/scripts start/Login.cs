using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PlayFab;
using PlayFab.ClientModels;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TopText;
    [SerializeField] TextMeshProUGUI MessageText;

    [Header("Login")]
    [SerializeField] TMP_InputField EmailLoginInput;
    [SerializeField] TMP_InputField PasswordLoginInput;
    [SerializeField] GameObject LoginPage;


    [Header("Register")]
    [SerializeField] TMP_InputField UsernameRegisterInput;
    [SerializeField] TMP_InputField EmailRegisterInput;
    [SerializeField] TMP_InputField PasswordRegisterInput;
    [SerializeField] GameObject RegisterPage;


    [Header("Recovery")]
    [SerializeField] TMP_InputField EmailRecoveryInput;
    [SerializeField] GameObject RecoverPage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Buttom functions

    public void RegisterUser()
    {
        var request = new RegisterPlayFabUserRequest
        {
            DisplayName = UsernameRegisterInput.text,
            Email = EmailRegisterInput.text,
            Password = PasswordRegisterInput.text,

            RequireBothUsernameAndEmail = false
        };

        PlayFabClientAPI.RegisterPlayFabUser(request, OnregisterSuccess, OnError);
    }


    public void login_button()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = EmailLoginInput.text,
            Password = PasswordLoginInput.text,

            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnloginSucces, OnErrorLog);
    }

    private void OnErrorLog(PlayFabError result)
    {
        TopText.text = "Incorrect password or email";
    }

    private void OnloginSucces(LoginResult result)
    {
        string name = null;

        if(result.InfoResultPayload != null)
        {
            name = result.InfoResultPayload.PlayerProfile.DisplayName;
        }

        TopText.text = "Welcome " + name;
        StartCoroutine(LoadNextScene());
    }

    public void RecoverUser()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = EmailRecoveryInput.text,
            TitleId = "8634C",
        };

        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnRecoverySucces, OnErrorRecovery);
    }

    private void OnErrorRecovery(PlayFabError result)
    {
        TopText.text = "No Mail Found";
    }

    private void OnRecoverySucces(SendAccountRecoveryEmailResult obj)
    {
        OpenLoginPage();
        TopText.text = "Recovery Mail Sent";
    }

    private void OnError(PlayFabError Error)
    {
        TopText.text = Error.ErrorMessage;
        Debug.Log(Error.GenerateErrorReport());

    }

    private void OnregisterSuccess(RegisterPlayFabUserResult Result)
    {
        TopText.text = "New Account Is Created";
        OpenLoginPage();

    }

    public void OpenLoginPage()
    {
        LoginPage.SetActive(true);
        RegisterPage.SetActive(false);
        RecoverPage.SetActive(false);
        TopText.text = "Login";
    }

    public void OpenRegisterPage()
    {
        LoginPage.SetActive(false);
        RegisterPage.SetActive(true);
        RecoverPage.SetActive(false);
        TopText.text = "Register";

    }

    public void OpenRecoveryPage()
    {
        LoginPage.SetActive(false);
        RegisterPage.SetActive(false);
        RecoverPage.SetActive(true);
        TopText.text = "Recover";

    }

    #endregion

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2);
        //TopText.text = "Loggin in";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
