# WPF Explorer [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.en.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md)  [![한국어](https://img.shields.io/badge/Language-한국어-green.svg)](README.md)

在Windows资源管理器克隆中展示高级WPF技术，包括MVVM、自定义控件和现代UI/UX设计。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/wpf-explorer.svg)](https://github.com/jamesnet214/wpf-explorer/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/wpf-explorer.svg)](https://github.com/jamesnet214/wpf-explorer/issues)

## 项目概述

WPF Explorer是《WPF INSIDE OUT》一书中的核心示例项目，旨在探索和实践WPF (Windows Presentation Foundation)的高级功能。该项目使用WPF复制了Windows资源管理器的功能，应用了各种高级WPF技术，如MVVM架构、依赖注入、自定义控件和高级样式技术。

<img src="https://github.com/user-attachments/assets/a7b9c310-6b2b-4268-bc50-ba56cccb383c" width="49%"/>
<img src="https://github.com/user-attachments/assets/8e547f5a-762b-43de-81c7-f6f816c9190d" width="49%"/>

<p/>

通过这个项目，开发人员可以学习以下实用的WPF技能：
- 复杂UI结构的高效设计和实现
- 使用MVVM模式编写清晰可维护的代码
- 使用自定义控件开发可重用的UI组件
- 应用现代UI/UX设计，包括暗黑主题实现
- 使用Jamesnet.Wpf库提高WPF开发效率

这个项目超越了简单的示例，包括了在实际工作中可能遇到的复杂需求和问题解决过程，这将极大地帮助提高WPF开发人员的技能。

## 主要特性

- Windows资源管理器功能的高级WPF实现
- 应用MVVM架构和依赖注入
- 使用自定义控件的模块化UI组合
- 基于暗黑主题的现代UI/UX设计
- 利用Jamesnet.Wpf库实现高效开发
- 复杂树结构和文件系统导航的实现
- 利用高级数据绑定和命令模式

## 技术栈

- .NET 8.0
- WPF (Windows Presentation Foundation) 
- Jamesnet.Wpf
- Prism
- CommunityToolkit.Mvvm

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

## 快速开始

##### 1. 克隆仓库：

```
git clone https://github.com/jamesnet214/wpf-explorer.git
```

##### 2. 在Visual Studio 2022或更高版本中打开解决方案
##### 3. 恢复所需的NuGet包
##### 4. 构建并运行项目

<p/>

## 《WPF INSIDE OUT》书籍简介

《WPF INSIDE OUT》是一本全面的指南，详细介绍了WPF的高级特性和实际应用方法。通过WPF Explorer项目，本书逐步解释了实际应用开发过程，为读者提供了实用的WPF开发经验。

### 购书链接
[购买WPF INSIDE OUT](https://jamesnet.dev/store)

![image](https://github.com/user-attachments/assets/d35b0f27-dae0-43e1-a8e4-66bab832d72a)

## 目录

1. 概述
   - 1.1 学习理念与方向
   - 1.2 设计元素的利用与理解
   - 1.3 (CustomControl)的专业化利用
   - 1.4 GitHub仓库
   - 1.5 外部库与依赖项
   - 1.6 .NET版本选择的重要性
   - 1.7 项目配置
   - 1.8 (项目概述)部分总结

2. 应用程序
   - 2.1 项目命名
   - 2.2 创建新项目(WpfExplorer)
   - 2.3 版本选择与项目创建
   - 2.4 移除默认配置文件
   - 2.5 库与依赖项
   - 2.6 App实现
   - 2.7 Starter实现
   - 2.8 (应用程序)部分总结
   
3. DarkWindow
   - 3.1 项目命名  
   - 3.2 创建项目(WpfExplorer.Support)
   - 3.3 管理Generic.xaml
   - 3.4 AssemblyInfo.cs文件与CustomControl关系
   - 3.5 创建自定义控件(CustomControl)
   - 3.6 创建资源字典
   - 3.7 实现窗口按钮
   - 3.8 CloseButton实现
   - 3.9 MaximizeButton实现  
   - 3.10 MinimizeButton实现
   - 3.11 合并Generic.xaml资源文件
   - 3.12 DarkWindow实现
   - 3.13 运行DarkWindow
   - 3.14 (DarkWindow)部分总结

4. 多个ItemsControls
   - 4.1 TreeView实现
   - 4.2 FolderTreeView实现  
   - 4.3 在View中添加FolderTreeView
   - 4.4 FolderTreeItem实现
   - 4.5 合并ResourceDictionary
   - 4.6 运行：FolderTreeItem测试
   - 4.7 替换TreeViewItem控件
   - 4.8 MVVM：实现ViewModel
   - 4.9 绑定：TestTitle
   - 4.10 分配DataContext
   - 4.11 运行：ViewModel绑定测试
   - 4.12 移除临时属性
   - 4.13 另一种绑定测试方法
   - 4.14 创建Model类
   - 4.15 创建DirectoryManager类(Helper)
   - 4.16 Prism简介
   - 4.17 注册单例对象
   - 4.18 管理ViewModel注册
   - 4.19 依赖注入
   - 4.20 (多个ItemsControls)部分总结

5. MainContent
   - 5.1 WpfExplorer.Main
   - 5.2 注册MainContent
   - 5.3 对象设计注意事项(依赖注入)
   - 5.4 更改ExplorerWindow结构
   - 5.5 MainContent依赖注入
   - 5.6 运行：MainContent测试
   - 5.7 将FolderTreeView相关文件移至项目
   - 5.8 创建窗口目录结构
   - 5.9 实现MainContent ViewModel
   - 5.10 实现MainContent View
   - 5.11 ItemsControl：指定子元素对象
   - 5.12 如何在ViewModel中实现事件
   - 5.13 TreeView事件绑定
   - 5.14 连接SelectionCommand
   - 5.15 运行：SelectionCommand测试
   - 5.16 创建更简化的ICommand
   - 5.17 TreeView层次结构
   - 5.18 连接TreeViewItem子项
   - 5.19 重写GetContainerForItem
   - 5.20 层次表达：DepthConverter
   - 5.21 显示/隐藏树子节点(IsExpanded)  
   - 5.22 ExpandButton实现(ToggleButton)
   - 5.23 实现最终TreeView资源
   - 5.24 (MainContent)部分总结

6. NavigatorService  
   - 6.1 实现单例实例
   - 6.2 依赖注入：NavigatorService实现
   - 6.3 绑定文件列表
   - 6.4 FileListBox实现
   - 6.5 创建详细文件列表
   - 6.6 PolygonSelector实现
   - 6.7 (NavigatorService)部分总结

7. LocationContent
   - 7.1 WpfExplorer.Location  
   - 7.2 模块化LocationContent View
   - 7.3 LocatorButton实现  
   - 7.4 LocatorTextBox实现
   - 7.5 合并Generic.xaml
   - 7.6 增强LocationContent View
   - 7.7 连接LocatorTextBox当前位置
   - 7.8 增强DarkWindow
   - 7.9 (LocationContent)部分总结

8. 高级功能 
   - 8.1 增强DarkScrollViewer
   - 8.2 初始化FolderTreeView  
   - 8.3 表示无法访问的目录
   - 8.4 (LocationContent)部分总结

## 学习资料

- [YouTube实践视频](https://www.youtube.com/watch?v=2PuvhTEcWAQ)
- [4小时完整教育视频](https://youtube.com/live/KtjC8a-BA1g)  

<img src="https://github.com/user-attachments/assets/8e547f5a-762b-43de-81c7-f6f816c9190d" width="49%"/>
<img src="https://github.com/user-attachments/assets/77f1fd54-66f2-46dc-91a2-977d5956c305" width="49%"/>

## 贡献

如果您想为这个项目做出贡献，请发送pull request。我们欢迎所有的贡献！

## 许可证

该项目采用MIT许可证。有关更多信息，请参阅[LICENSE](LICENSE)文件。

## 联系方式

- 网站：https://jamesnet.dev
- 电子邮件：james@jamesnet.dev, vickyqu115@hotmail.com
