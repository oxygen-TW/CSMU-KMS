echo 偵測 Microsoft Office 2013 安裝目錄
set OfficePath="C:\Program Files\Microsoft Office\Office15\"
if exist "C:\Program Files (x86)\Microsoft Office\Office15\ospp.vbs" set OfficePath="C:\Program Files (x86)\Microsoft Office\Office15\"
For /F "tokens=2 delims=[]" %%G in ('ver') Do (set _version=%%G) 
For /F "tokens=2 delims=. " %%G in ('echo %_version%') Do (set _major=%%G) 
if "%_major%"=="5" (echo 重啟 KMS 金鑰管理伺服器
cscript %OfficePath%ospp.vbs /osppsvcrestart)
echo 開啟 KMS 金鑰管理伺服器
cscript %OfficePath%ospp.vbs /sethst:kms.csmu.edu.tw
cscript %OfficePath%ospp.vbs /setprt:1688
echo 啟動 Microsoft Office 2013
cscript %OfficePath%ospp.vbs /act
echo 啟動程序執行完成
echo 請注意: 上方(前五行)顯示 Product  activation  successful ,
echo 才表示您的 Office2013 認證成功!
echo "finished"