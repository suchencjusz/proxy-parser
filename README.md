# proxychains parser
[![Build Status](https://travis-ci.org/suchy2020/proxy-parser.svg?branch=main)](https://travis-ci.org/suchy2020/proxy-parser)

Need parse proxies from that:
```
45.95.96.132:1080:qrygtp-dest:7u9b
45.95.96.237:1080:qrygtp-dest:7u9b
45.95.96.187:1080:qrygtp-dest:7u9b
45.94.47.66:1080:qrygtp-dest:7u9b
193.8.56.119:1080:qrygtp-dest:7u9b
```
to that (proxychains):
```
socks5  45.95.96.132    1080    qryiwgtp-dest   7u9bp
socks5  45.95.96.237    1080    qryiwgtp-dest   7u9bp
socks5  45.95.96.187    1080    qryiwgtp-dest   7u9bp
socks5  45.94.47.66     1080    qryiwgtp-dest   7u9bp
socks5  193.8.56.119    1080    qryiwgtp-dest   7u9bp
```

------------
# Linux build 
```
git clone https://github.com/suchy2020/proxy-parser
```
Move to **.csproj** file, and build with **xbuild**
```
xbuild proxy-parser.csproj
```
Compiled program will be show in **bin** subfolder

Copy & paste install
```
git clone https://github.com/suchy2020/proxy-parser 
xbuild proxy-parser/proxy-parser/proxy-parser.csproj 
mono proxy-parser/proxy-parser/bin/Debug/proxy-parser.exe 
```
------------
# Solutions for errors
xbuild errors:

/usr/lib/mono/xbuild/14.0/bin/Microsoft.Common.targets:  warning : TargetFrameworkVersion 'v4.7.2' not supported by this toolset (ToolsVersion: 14.0).   

edit **proxy-parser.csproj** and change
```
<TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>
```
to other version
```
<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
```



