; Copyrights(c)2020-2021 RED Modding Tools. All Rights Reserved.
; script version: v1.3.5.1
; Changelog:
; v1.3.5:
; *Added custom image file and banner.
;
; v1.3:
; *Cleaned code. Now it is useable by anyone.
; *Full support of VS.
;
; v1.2:
; *Removed third party pulgin. Now using the integrated download function.
; *Downloader is working.
;
; v1.1:
; *Changed License file source folder to local.
; *Added few comments to clarify things.
; *WIP integration of downloader plugin.

/// To build a working installer, please change the <PATH> to what it says.


[Code]

#define MyAppName "WolvenKit"
#define MyAppVersion "0.8.0.1"
#define SetupVersion "1.3.5.1"

// below we put the Build which is used in the setup [Dev, Preview, Beta, Production]
#define WkitBuildVer "BETA"

#define MyAppPublisher "RED Modding Tools"
#define MyAppURL "https://redmodding.org/"
#define MyAppExeName "WolvenKit.exe"

#define RedistsNET "https://download.visualstudio.microsoft.com/download/pr/7a5d15ae-0487-428d-8262-2824279ccc00/6a10ce9e632bce818ce6698d9e9faf39/windowsdesktop-runtime-5.0.4-win-x64.exe"
#define RedistsWebView "https://msedge.sf.dl.delivery.mp.microsoft.com/filestreamingservice/files/8e88f2e1-4014-4458-9498-3ac1d460b172/MicrosoftEdgeWebView2RuntimeInstallerX64.exe"



// bellow is code for downloder.    --NEEDS MORE WORK BUT FOR NOW IT DOES THE JOB--



var
  DownloadPage: TDownloadWizardPage;

function OnDownloadProgress(const Url, FileName: String; const Progress, ProgressMax: Int64): Boolean;
begin
  if Progress = ProgressMax then
    Log(Format('Successfully downloaded file to {tmp}: %s', [FileName]));
  Result := True;
end;

procedure InitializeWizard;
begin
  DownloadPage := CreateDownloadPage(SetupMessage(msgWizardPreparing), SetupMessage(msgPreparingDesc), @OnDownloadProgress);
end;

function NextButtonClick(CurPageID: Integer): Boolean;
begin
  if CurPageID = wpReady then begin
    DownloadPage.Clear;
    DownloadPage.Add('{#RedistsNET}', 'dotnet-runtime-5.0.4-win-x64.exe', '');    //Downloads the required .NET Framework
    DownloadPage.Add('{#RedistsWebView}', 'Microsoft_WebView_x64.exe', '');            // Downloads the WebView
    DownloadPage.Show;
    try
      try
        DownloadPage.Download;
        Result := True;
      except
        SuppressibleMsgBox(AddPeriod(GetExceptionMessage), mbCriticalError, MB_OK, IDOK);
        Result := False;
      end;
    finally
      DownloadPage.Hide;
    end;
  end else
    Result := True;
end;




[Setup]
; DO NOT CHANGE THE APPID. IT IS USED FOR UPDATES!

AppId={{CB4121C6-93E5-4985-8EDD-D956C5B776A9}
AppName={#MyAppName}
VersionInfoVersion={#SetupVersion}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion} {#WkitBuildVer}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\RED Modding Team\WolvenKit\
DisableProgramGroupPage=yes

; change the next line to put your own License file.
LicenseFile=C:\Users\cancerPC\source\repos\Wolvenkit\WolvenKit.Inno.Installer\files\wkit_license_2.rtf


;PrivilegesRequired=lowest      ; Uncomment the following line to run in non administrative install mode (install for current user only.)

PrivilegesRequiredOverridesAllowed=dialog
; the folder where the setup.exe file will be put after compilation. Change it to your own folder of choice.
OutputDir=C:\Users\cancerPC\Desktop\New folder
OutputBaseFilename=WolvenKit_{#MyAppVersion}-{#WkitBuildVer}
SolidCompression=yes
WizardStyle=modern
WizardImageFile=C:\Users\cancerPC\source\repos\Wolvenkit\WolvenKit.Inno.Installer\files\banner_vertical.bmp
WizardSmallImageFile=C:\Users\cancerPC\source\repos\Wolvenkit\WolvenKit.Inno.Installer\files\WkitEd.bmp
AppCopyright=(c)2020 - 2021 RED Modding Tools
VersionInfoCompany=RED Modding Tools
; change the versionInfoProductName to the corresponding Wkit version
VersionInfoProductName=WolvenKit {#MyAppVersion} {#WkitBuildVer}
InternalCompressLevel=max

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "czech"; MessagesFile: "compiler:Languages\Czech.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"
Name: "polish"; MessagesFile: "compiler:Languages\Polish.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked



[Files]

// ----------------SETUP FILES----------------
// Change the following to where the build of Wkit is.
Source: "C:\Users\cancerPC\source\repos\Wolvenkit\WolvenKit\bin\Release\net5.0-windows\win-x64\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\cancerPC\source\repos\Wolvenkit\WolvenKit\bin\Release\net5.0-windows\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

// Below are the files to download. any file should be downloaded must be put below.
// --------------FILE TO DOWNLOAD-------------
Source: "{tmp}\dotnet-runtime-5.0.4-win-x64.exe"; DestDir: "{app}\_Redists"; Flags: external
Source: "{tmp}\Microsoft_WebView_x64.exe"; DestDir: "{app}\_Redists"; Flags: external



[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
// Gives choice of running the app and installing the 3rd party redists
;Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent       //LEAVE IT COMMENTED
Filename: "{app}\_Redists\dotnet-runtime-5.0.4-win-x64.exe"; Flags: postinstall
Filename: "{app}\_Redists\Microsoft_WebView_x64.exe"; Flags: postinstall


