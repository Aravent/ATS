# 总览

## 扩展包

Testing Studio Sample 的构建考虑了可扩展性，从仪器驱动到数据处理，基本上都可以通过载入扩展包对TS Sample的功能进行个性化或增强。实际上，TS Sample的许多基本功能都是由扩展包进行构建的。

本文档的描述：
* 如何构建、调试、测试和发布扩展包
* 如何利用TS Sample的接口来扩展您的扩展包
* 为您提供扩展包开发的指南和提供基本代码示例

如果您正在寻找已经发布的扩展包，请前往[APC Extension Marketplace](https://apc.anycen.com)。

### 扩展包可以做什么？

以下是扩展包可以实现的一些实例：

* 使用串口控制固纬电源，并在输出后显示获取的电压/流数据 - [固纬电源控制器](https://apc.anycen.com)
* 在UI中添加自定义菜单与功能按钮调用扩展包中的方法 - [图像二值化处理工具](https://apc.anycen.com)
* 获取其他扩展包推送的数据进行状态管理 - [状态管理工具](https://apc.anycen.com)
* 通过调用其他扩展包中的方法完成基本的队列流程跑合 - [简易流程跑合工具](https://apc.anycen.com)

如果您想对扩展包进行更全面的概述，请参阅“扩展包功能概述”页面。扩展包功能概述还包括代码示例列表和说明各种扩展包接口用法的指南。

### 如何学习构建扩展包？

构建一个良好的扩展包可能需要很多工作。以下是该文档的每个章节能为您提供的帮助：
* **入门** 使用“Hello Word”示例教程学习构建扩展包的基本概念。
* **使用扩展包** 包含有关各种扩展包开发与使用的进一步指导，例如[测试]()和[发布]()您的扩展包。
* **扩展接口** 将TS Sample的扩展接口进行细化与分类，为您提供更详细的参考与例程。
* **UI扩展**　包含了如何利用接口在TS Sample UI上[注册菜单]()、[显示功能按钮]()、[修改状态栏内容]()以及[推送消息]()。
* **数据交互** 介绍了如何通过公共数据接口列表[获取数据]()或[推送数据]()，并进行进一步的操作。
* **参考** 包含了核心扩展包中的部分函数与数据，贡献以及许多其他主题。

## 寻求帮助

如果您对扩展包程序开发有疑问，请创建issue进行提问。
如果您迫切想得到回复，请发送邮件至[zlxu@aiofm.ac.cn](mailto://zlxu@aiofm.ac.cn)我将尽快恢复您的问题。


# 入门

## 您的第一个扩展包

在本主题中，我们将指导您构建扩展包程序的基本概念。请确保您已经安装了[Visual Studio 2010]()版本以上，[.NET Framework 4.0]()以上：

>此处我们以Visual Studio 2019与.NET Framework 4.6.1为例

首先您需要在Testing Studio Sample的根目录下找到 `Doc\ExtendDemo` 目录获取 `APCInterface.dll` 接口库

>您可以在此处直接获取：[APCInterface.dll]()

### 开发扩展包

打开VS 2019,新建WinForm项目

### 调试扩展包

使用调试工具调试

### 测试扩展包

将扩展包放置于Testing Studio Sample根目录下`\Extension`

## 延伸剖析

在上一个主题中，您能够运行基本扩展。它是如何工作的？

该`Hello World`扩展程序执行3件事:

* 注册激活事件：，因此，当用户运行命令时，扩展名将被激活。
* 注册数据事件:
* 调用公共接口方法:

理解这三个概念对于用TS Sample编写扩展包至关重要：

* 激活事件：您的扩展激活时所发生的事件。
* 注册数据事件：您在package.json 扩展清单中为扩展VS代码所做的静态声明。
* 调用公共接口方法：可以在扩展代码中调用的一组JavaScript API。

通常，您的扩展程序将结合使用贡献点和VS Code API来扩展VS Code的功能。在扩展功能概述主题帮助您找到合适的贡献分和VS代码API为您的扩展。

让我们仔细看一下Hello World示例的源代码，看看这些概念如何应用于它。

### 扩展包文件结构

    <?php
        打法
        大师傅
        大师傅
    ?>

### 打包扩展

在“您的第一个扩展包”主题中，您学习了如何创建，运行和调试扩展。在“延伸剖析”主题中，您学习了Testing Studio Sample扩展开发的基本概念。但是，我们只看到了冰山一角，这是一些建议的方法，可用来提高TS Sample扩展开发技能。

### 使用扩展

本部分包括有助于您开发高质量TS Sample扩展的主题。例如，您可以学习

* 如何为您的扩展添加[集成测试]()
* 如何[将扩展发布]()到APC Extension Marketplace
* 如何为您的扩展程序设置持续集成

### 扩展能力

在本节中，我们将TS Sample接口和贡献点分为几类，每类都简要说明了您的扩展可以实现的目标。验证您的扩展想法可以通过TS Sample接口实现，或者在此处查找新的扩展想法。

## 指南和示例

我们提供了大量示例扩展，您可以从中进行调整，其中一些示例包含详细的指南以解释源代码。您可以在扩展指南列表或[apc-extension-samples]()存储库中找到所有示例和指南。


# 使用扩展包


# 扩展接口

## 综述

在TS Sample中，扩展包利用扩展接口与框架进行数据交换，为此我们定义了以下四种数据交换的方式：
|名称|方向|继承&调用|方法|
|---|---|---|---|
|读取|框架 < 模块|ICore|[PushInfo]() [Init](#init-方法)([IPush]() push)|
|发送|框架 > 模块|ICore|void [Receive](#receive-方法)([PushData]() pushData)|
|获取|模块 < 框架|IPush|[MethodData]() [GetMethodList](#getmethodlist-方法)()<br>[ModuleData]() [GetDataList](#getdatalist-方法)()<br>object [GetData](#getdata-方法)(int pid, [PushType]() type, string name)|
|推送|模块 > 框架|IPush|int [Pid](#pid-属性) {get; set;}<br>void [PushData](#pushdata-方法)(int pid, [PushData]() pushData)<br>void [PushNotice](#pushnotice-方法)(int pid, [PushNotice]() pushNotice)|

## 属性

### PID 属性

#### 语法

`public int Pid { get; set; }`

#### 简介

用于设置和获取注册扩展包的PID值，通常在Init(IPush push)方法中被引入。

#### 示例

```C#
    private IPush Push;

    public PushInfo Init(IPush push)
    {
        Push = push;
        return null;
    }

    var pid = Push.Pid;
```

#### 另请参阅

[System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

## 方法

### Init 方法

#### 语法

`public PushInfo Init(IPush push);`

#### 参数

**return** [PushInfo]()

扩展包向框架中注册的信息。

**push** [IPush]()

由框架传入的推送接口实例。

#### 简介

扩展包初始化。

#### 示例

```C#
    private IPush Push;

    public PushInfo Init(IPush push)
    {
        Push = push;
        return null;
    }

    var pid = Push.Pid;
```

#### 另请参阅

无

### Receive 方法

#### 语法

`public void Receive(PushData query);`

#### 参数

**query** [PushData]()

接收的数据。

#### 简介

扩展包数据接收。

#### 示例

```C#
    public void Receive(PushData query)
    {
        switch (query.Type)
        {
            case PushType.Setting :
                MessageBox.Show((string)query.Data[0].Value);
                break;
            default:
                break;
        }
    }
```

#### 另请参阅

[System.Void](https://docs.microsoft.com/zh-cn/dotnet/api/system.void?view=netframework-4.6)

[System.String](https://docs.microsoft.com/zh-cn/dotnet/api/system.string?view=netframework-4.6)

[System.Windows.MessageBox](https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.messagebox?view=netframework-4.6)


### GetMethodList 方法

#### 语法

`public MethodData GetMethodList();`

#### 参数

**return** [MethodData]()

读取的方法列表。

#### 简介

扩展包从框架中读取的全部注册方法列表。

#### 示例

```C#
    var MethodList = IPush.GetMethodList();
```

#### 另请参阅

无

### GetDataList 方法

#### 语法

`public ModuleData GetDataList()`

#### 参数

**return** [ModuleData]()

读取的数据列表。

#### 简介

扩展包从框架中读取的全部注册数据列表。

#### 示例

```C#
    var DataList = IPush.GetDataList();
```

#### 另请参阅

无

### GetData 方法

#### 语法

`public object GetData(int pid, PushType type, string name);`

#### 参数

**return** [System.Object](https://docs.microsoft.com/zh-cn/dotnet/api/system.object?view=netframework-4.6)

读取的数据值。

**pid** [System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

要读取数据所在扩展包Pid。

**type** [PushType]()

获取数据的类型。

**name** [System.String](https://docs.microsoft.com/zh-cn/dotnet/api/system.string?view=netframework-4.6)

获取数据的名称。

#### 简介

扩展包从框架中读取其他指定扩展包推送的数据。

#### 示例

```C#
    var Data = IPush.GetData(1001, PushType.Setting, "isEnable");
```

#### 另请参阅

[System.Object](https://docs.microsoft.com/zh-cn/dotnet/api/system.object?view=netframework-4.6)

[System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

[System.String](https://docs.microsoft.com/zh-cn/dotnet/api/system.string?view=netframework-4.6)

### PushData 方法

#### 语法

`public void PushData(int pid, PushData pushData);`

#### 参数

**pid** [System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

本扩展包的Pid。

**pushData** [PushData]()

要推送的数据。

#### 简介

推送数据到框架。

#### 示例

```C#
    var regData = new PushData
    {
        Type = PushType.RegData,
        Data = dataInfos
    };
    Push.PushData(Push.Pid, regData);
```

#### 另请参阅

[System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

### PushNotice 方法

#### 语法

`public void PushNotice(int pid, PushNotice pushNotice);`

#### 参数

**pid** [System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

本扩展包的Pid。

**pushNotice** [PushNotice]()

要推送的通知。

#### 简介

向框架推送全局通知。

#### 示例

```C#
    PushNotice notice = new PushNotice
    { 
        Module = "Example",
        Title="TestNotice",
        Msg = "Example System Notice.",
        State = ToolTipIcon.Info
    };
    Push.PushNotice(Push.Pid, notice);
```

#### 另请参阅

[System.Int32](https://docs.microsoft.com/zh-cn/dotnet/api/system.int32?view=netframework-4.6)

## 类型

## 枚举

# UI扩展


# 数据交互


# 参考