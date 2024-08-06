# WPF Explorer [![한국어](https://img.shields.io/badge/Language-한국어-blue.svg)](README.md) [![English](https://img.shields.io/badge/Language-English-green.svg)](README.en.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md)

A showcase of advanced WPF techniques, including MVVM, custom controls, and modern UI/UX design, in a Windows Explorer clone.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/wpf-explorer.svg)](https://github.com/jamesnet214/wpf-explorer/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/wpf-explorer.svg)](https://github.com/jamesnet214/wpf-explorer/issues)


## Project Overview

WPF Explorer is the core example project in the "WPF INSIDE OUT" book, designed to explore and practice advanced features of WPF (Windows Presentation Foundation). This project replicates the functionality of Windows Explorer using WPF, applying various advanced WPF techniques such as MVVM architecture, dependency injection, custom controls, and advanced styling techniques.

<img src="https://github.com/user-attachments/assets/a7b9c310-6b2b-4268-bc50-ba56cccb383c" width="49%"/>
<img src="https://github.com/user-attachments/assets/8e547f5a-762b-43de-81c7-f6f816c9190d" width="49%"/>

Through this project, developers can learn the following practical WPF skills:
- Efficient design and implementation of complex UI structures
- Writing clean and maintainable code using the MVVM pattern
- Developing reusable UI components with custom controls 
- Applying modern UI/UX design, including dark theme implementation
- Improving WPF development productivity using the Jamesnet.Wpf library

This project goes beyond simple examples and includes complex requirements and problem-solving processes that may be encountered in real-world work, which will greatly help improve the skills of WPF developers.


## Key Features

- Advanced WPF implementation of Windows Explorer functionality
- Application of MVVM architecture and dependency injection
- Modularized UI composition using custom controls
- Modern UI/UX design based on a dark theme
- Efficient development utilizing the Jamesnet.Wpf library
- Implementation of complex tree structures and file system navigation
- Utilization of advanced data binding and command patterns
  
## Tech Stack

- .NET 8.0
- WPF (Windows Presentation Foundation) 
- Jamesnet.Wpf
- Prism
- CommunityToolkit.Mvvm

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

## Getting Started

#### 1. Clone the repository:

```
git clone https://github.com/jamesnet214/wpf-explorer.git
```

#### 2. Open the solution in Visual Studio 2022 or later
#### 3. Restore required NuGet packages
#### 4. Build and run the project



## Introduction to the "WPF INSIDE OUT" Book

"WPF INSIDE OUT" is a comprehensive guidebook that covers advanced features and practical application methods of WPF in detail. Through the WPF Explorer project, this book explains the actual application development process step by step, providing readers with practical WPF development experience.

### Book Purchase Link
[Buy WPF INSIDE OUT](https://jamesnet.dev/store)

![image](https://github.com/user-attachments/assets/d35b0f27-dae0-43e1-a8e4-66bab832d72a)

## Table of Contents

1. OVERVIEW
   - 1.1 Philosophy and Direction of Learning
   - 1.2 Utilization and Understanding of Design Elements
   - 1.3 Professional Utilization of (CustomControl)
   - 1.4 GitHub Repository
   - 1.5 External Libraries and Dependencies
   - 1.6 Importance of .NET Version Selection
   - 1.7 Project Configuration
   - 1.8 Wrapping up the (Project Overview) Section

2. Application
   - 2.1 Project Naming
   - 2.2 Creating a New Project (WpfExplorer)
   - 2.3 Version Selection and Project Creation
   - 2.4 Removing Default Configuration Files
   - 2.5 Libraries and Dependencies
   - 2.6 App Implementation
   - 2.7 Starter Implementation
   - 2.8 Wrapping up the (Application) Section
   
3. DarkWindow
   - 3.1 Project Naming  
   - 3.2 Creating the Project (WpfExplorer.Support)
   - 3.3 Managing Generic.xaml
   - 3.4 AssemblyInfo.cs File and CustomControl Relationship
   - 3.5 Creating a Custom Control (CustomControl)
   - 3.6 Creating a Resource Dictionary
   - 3.7 Implementing Window Buttons
   - 3.8 CloseButton Implementation
   - 3.9 MaximizeButton Implementation  
   - 3.10 MinimizeButton Implementation
   - 3.11 Merging Generic.xaml Resource File
   - 3.12 DarkWindow Implementation
   - 3.13 Running DarkWindow
   - 3.14 Wrapping up the (DarkWindow) Section

4. Multiple ItemsControls
   - 4.1 TreeView Implementation
   - 4.2 FolderTreeView Implementation  
   - 4.3 Adding FolderTreeView in the View
   - 4.4 FolderTreeItem Implementation
   - 4.5 Merging ResourceDictionary
   - 4.6 Running: FolderTreeItem Test
   - 4.7 Replacing TreeViewItem Control
   - 4.8 MVVM: Implementing ViewModel
   - 4.9 Binding: TestTitle
   - 4.10 Assigning DataContext
   - 4.11 Running: ViewModel Binding Test
   - 4.12 Removing Temporary Properties
   - 4.13 Another Binding Test Method
   - 4.14 Creating Model Classes
   - 4.15 Creating DirectoryManager Class (Helper)
   - 4.16 Brief Introduction to Prism
   - 4.17 Registering Singleton Objects
   - 4.18 Managing ViewModel Registration
   - 4.19 Dependency Injection
   - 4.20 Wrapping up the (Multiple ItemsControls) Section  

5. MainContent
   - 5.1 WpfExplorer.Main
   - 5.2 Registering MainContent
   - 5.3 Cautions on Object Design (Dependency Injection)
   - 5.4 Changing ExplorerWindow Structure
   - 5.5 MainContent Dependency Injection
   - 5.6 Running: MainContent Test
   - 5.7 Moving FolderTreeView Related Files to Project
   - 5.8 Creating Window Directory Structure
   - 5.9 Implementing MainContent ViewModel
   - 5.10 Implementing MainContent View
   - 5.11 ItemsControl: Specifying Child Element Objects
   - 5.12 How to Implement Events in the ViewModel
   - 5.13 TreeView Event Binding
   - 5.14 Connecting SelectionCommand
   - 5.15 Running: SelectionCommand Test
   - 5.16 Creating a More Simplified ICommand
   - 5.17 TreeView Hierarchy Structure
   - 5.18 Connecting TreeViewItem Children
   - 5.19 Overriding GetContainerForItem
   - 5.20 Hierarchy Expression: DepthConverter
   - 5.21 Showing/Hiding Tree Child Nodes (IsExpanded)  
   - 5.22 ExpandButton Implementation (ToggleButton)
   - 5.23 Implementing Final TreeView Resources
   - 5.24 Wrapping up the (MainContent) Section

6. NavigatorService  
   - 6.1 Implementing Singleton Instance
   - 6.2 Dependency Injection: NavigatorService Implementation
   - 6.3 Binding File List
   - 6.4 FileListBox Implementation
   - 6.5 Creating Detailed File List
   - 6.6 PolygonSelector Implementation
   - 6.7 Wrapping up the (NavigatorService) Section

7. LocationContent
   - 7.1 WpfExplorer.Location  
   - 7.2 Modularizing LocationContent View
   - 7.3 LocatorButton Implementation  
   - 7.4 LocatorTextBox Implementation
   - 7.5 Merging Generic.xaml
   - 7.6 Enhancing LocationContent View
   - 7.7 Connecting LocatorTextBox Current Location
   - 7.8 Enhancing DarkWindow
   - 7.9 Wrapping up the (LocationContent) Section

8. Advancement 
   - 8.1 Enhancing DarkScrollViewer
   - 8.2 Initializing FolderTreeView  
   - 8.3 Representing Inaccessible Directories
   - 8.4 Wrapping up the (LocationContent) Section

## Learning Materials

- [YouTube Practice Videos](https://www.youtube.com/watch?v=2PuvhTEcWAQ)
- [4-Hour Full Education Video](https://youtube.com/live/KtjC8a-BA1g)  

<img src="https://github.com/user-attachments/assets/8e547f5a-762b-43de-81c7-f6f816c9190d" width="49%"/>
<img src="https://github.com/user-attachments/assets/77f1fd54-66f2-46dc-91a2-977d5956c305" width="49%"/>

## Contributing

If you would like to contribute to this project, please send a pull request. All contributions are welcome!

## License

This project is under the MIT License. For more information, see the [LICENSE](LICENSE) file.

## Contact

- Website: https://jamesnet.dev
- Email: james@jamesnet.dev, vickyqu115@hotmail.com
