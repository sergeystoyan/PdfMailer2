; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Code]
function AppName(Param: String): String;
begin
  Result := 'PdfMailer2';
end;

function Version(Param: String): String;
begin
  Result := '0.1';
end;

[Setup]
OutputBaseFilename=PdfMailer2.Setup
AppName={code:AppName}
AppVerName={code:AppName} {code:Version}
AppPublisher=CliverSoft.com
AppPublisherURL=http://www.cliversoft.com
AppSupportURL=http://www.cliversoft.com
AppUpdatesURL=http://www.cliversoft.com
DefaultDirName={pf}\CliverSoft\{code:AppName}
DefaultGroupName=CliverSoft
;InfoAfterFile=.\install_notes.txt
Compression=lzma
SolidCompression=yes
;VersionInfoDescription       
UsePreviousLanguage=no

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkedonce

[Files]
;Source: ".\_config_files\*.*"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\bin\Release\*.*"; Excludes: "*.pdb,*.vshost.*,.svn,"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{code:AppName}"; Filename: "{app}\{code:AppName}.exe"
Name: "{userdesktop}\{code:AppName}"; Filename: "{app}\{code:AppName}.exe"; Tasks: desktopicon
Name: "{group}\Uninstall\{cm:UninstallProgram,{code:AppName}}"; Filename: "{uninstallexe}" 
;Name: "{group}\{code:AppName} Configure"; Filename: "{app}\{code:AppName}.exe"; Parameters: "-configure"

[Run]
Filename: "{app}\{code:AppName}.exe"; Description: "{cm:LaunchProgram,{code:AppName}}"; Flags: nowait postinstall skipifsilent

