# LiveWallpaperEngine

新版本正在开发，旧的可用版本查看tag v0.1

---

## 定位:
  动态壁纸最核心的那层功能

## 愿景：
提供公用api，上传到nuget，让所有程序都可以成为壁纸。。。

## 当前工作重点：
把工程全面支持 .net core3

## 功能目标：
- [x] 嵌入桌面
- [ ] 鼠标事件转发 (待研究，有懂的可以提交issue，发布资料或者demo 感谢)  
具体描述:窗口在桌面下面，不能响应鼠标事件。 如何在桌面移动鼠标时，让桌面下的窗口能收到同样的windows消息。

- [x] 支持多屏幕
- [x] 内置播放器
- [ ] 内置浏览器 （开发中）

## 对于开源的期望:
希望大家一起完善开源项目，不一定要提交代码，提交需求或者bug也是一种支持。
另外对于那些抄着开源代码，自己另起炉灶甚至把核心代码闭源的人，我表示强烈的鄙视。c#社区力量不强，希望大家一起出力。

## 严禁闭源项目抄袭使用本仓库代码，保留法律权利。

## 运行效果：
* 本仓库自带demo，运行即可。  
* 也可以查看我利用本仓库实现的动态壁纸小软件：   
https://www.mscoder.cn/product/livewallpaper/

## 开发环境
vs2019 Preview
.net core 3.0

## 其他注意事项：
* 开启360、腾讯管家等全家桶软件，有可能无法嵌入桌面
* 已在部分电脑发现，无法激活WorkerW句柄，导致功能无法实现

## 感谢这些作者的开源精神：
https://www.codeproject.com/Articles/856020/Draw-Behind-Desktop-Icons-in-Windows  
https://github.com/Francesco149/weebp/blob/master/src/weebp.c  

## 如果对你有帮助请star支持一下。你们的支持是我搞下去的动力~~
