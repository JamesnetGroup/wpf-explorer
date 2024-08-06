# WPF Explorer [![한국어](https://img.shields.io/badge/Language-한국어-blue.svg)](README.md) [![English](https://img.shields.io/badge/Language-English-green.svg)](README.en.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md)

Windows Explorer 클론에서 MVVM, 사용자 정의 컨트롤, 현대적인 UI/UX 디자인을 포함한 고급 WPF 기술을 선보입니다.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/wpf-explorer.svg)](https://github.com/jamesnet214/wpf-explorer/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/wpf-explorer.svg)](https://github.com/jamesnet214/wpf-explorer/issues)

## 프로젝트 개요

WPF Explorer는 "WPF INSIDE OUT" 책의 핵심 예제 프로젝트로, WPF(Windows Presentation Foundation)의 고급 기능을 탐구하고 실습하기 위해 설계되었습니다. 이 프로젝트는 WPF를 사용하여 Windows Explorer의 기능을 복제하며, MVVM 아키텍처, 의존성 주입, 사용자 정의 컨트롤, 고급 스타일링 기법 등 다양한 고급 WPF 기술을 적용합니다.

<img src="https://github.com/user-attachments/assets/a7b9c310-6b2b-4268-bc50-ba56cccb383c" width="49%"/>
<img src="https://github.com/user-attachments/assets/8e547f5a-762b-43de-81c7-f6f816c9190d" width="49%"/>

이 프로젝트를 통해 개발자들은 다음과 같은 실용적인 WPF 기술을 배울 수 있습니다:
- 복잡한 UI 구조의 효율적인 설계 및 구현
- MVVM 패턴을 사용한 깨끗하고 유지보수가 쉬운 코드 작성
- 사용자 정의 컨트롤을 통한 재사용 가능한 UI 컴포넌트 개발
- 다크 테마 구현을 포함한 현대적인 UI/UX 디자인 적용
- Jamesnet.Wpf 라이브러리를 사용한 WPF 개발 생산성 향상

이 프로젝트는 단순한 예제를 넘어 실제 업무에서 마주할 수 있는 복잡한 요구사항과 문제 해결 과정을 포함하고 있어, WPF 개발자들의 기술 향상에 크게 도움이 될 것입니다.

## 주요 기능

- Windows Explorer 기능의 고급 WPF 구현
- MVVM 아키텍처 및 의존성 주입 적용
- 사용자 정의 컨트롤을 사용한 모듈화된 UI 구성
- 다크 테마 기반의 현대적인 UI/UX 디자인
- Jamesnet.Wpf 라이브러리를 활용한 효율적인 개발
- 복잡한 트리 구조 및 파일 시스템 탐색 구현
- 고급 데이터 바인딩 및 명령 패턴 활용

## 기술 스택

- .NET 8.0
- WPF (Windows Presentation Foundation)
- Jamesnet.Wpf
- Prism
- CommunityToolkit.Mvvm

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

## 시작하기

##### 1. 저장소 복제:

```
git clone https://github.com/jamesnet214/wpf-explorer.git
```

##### 2. Visual Studio 2022 이상에서 솔루션 열기
##### 3. 필요한 NuGet 패키지 복원
##### 4. 프로젝트 빌드 및 실행

## "WPF INSIDE OUT" 책 소개

"WPF INSIDE OUT"은 WPF의 고급 기능과 실용적인 적용 방법을 상세히 다루는 종합 안내서입니다. WPF Explorer 프로젝트를 통해 이 책은 실제 애플리케이션 개발 과정을 단계별로 설명하며, 독자들에게 실용적인 WPF 개발 경험을 제공합니다.

### 책 구매 링크
[WPF INSIDE OUT 구매하기](https://jamesnet.dev/store)

![image](https://github.com/user-attachments/assets/d35b0f27-dae0-43e1-a8e4-66bab832d72a)

## 목차

1. OVERVIEW
- 1.1 학습의 철학과 방향성에 대해
- 1.2 디자인 요소의 활용과 이해
- 1.3 (CustomControl) 의 전문적인 활용
- 1.4 GitHub 레포지터리
- 1.5 외부 라이브러리와 종속성 관계
- 1.6 .NET 버전 선택의 중요성
- 1.7 프로젝트 구성
- 1.8 (Project Overview) 섹션의 마무리

2. Application
- 2.1 프로젝트 네이밍
- 2.2 새 프로젝트 만들기 (WpfExplorer)
- 2.3 버전 선택 및 프로젝트 만들기
- 2.4 기본 구성 파일 제거
- 2.5 라이브러리와 종속성
- 2.6 App 구현
- 2.7 Starter 구현
- 2.8 (Application) 섹션의 마무리

3. DarkWindow
- 3.1 프로젝트 네이밍
- 3.2 프로젝트 만들기 (WpfExplorer.Support)
- 3.3 Generic.xaml 관리
- 3.4 AssemblyInfo.cs 파일과 CustomControl 관계
- 3.5 사용자 지정 컨트롤 (CustomControl) 생성
- 3.6 리소스 사전 (ResourceDictionary) 생성
- 3.7 윈도우 버튼 구현
- 3.8 CloseButton 구현
- 3.9 MaximizeButton 구현
- 3.10 MinimizeButton 구현
- 3.11 Generic.xaml 리소스 파일 병합
- 3.12 DarkWindow 구현
- 3.13 DarkWindow 실행
- 3.14 (Darkwindow) 섹션의 마무리

4. Multiple ItemsControl
- 4.1 TreeView 구현
- 4.2 FolderTreeView 구현
- 4.3 뷰에서 FolderTreeView 추가
- 4.4 FolderTreeItem 구현
- 4.5 ResourceDictionary의 병합
- 4.6 실행: FolderTreeItem 테스트
- 4.7 TreeViewItem 컨트롤 대체하기
- 4.8 MVVM: 뷰모델 구현하기
- 4.9 바인딩: TestTitle
- 4.10 DataContext 할당하기
- 4.11 실행: ViewModel 바인딩 테스트
- 4.12 임시 속성 제거하기
- 4.13 또 다른 바인딩 테스트 방법
- 4.14 모델 클래스 생성
- 4.15 DirectoryManager 클래스 생성 (Helper)
- 4.16 Prism에 대한 간략한 소개
- 4.17 싱글턴 객체 등록하기
- 4.18 ViewModel 등록 관리
- 4.19 의존성 주입
- 4.20 (Multiple ItemsControl) 섹션의 마무리

5. MainContent
- 5.1 WpfExplorer.Main
- 5.2 MainContent 등록
- 5.3 객체 설계에 대한 주의 사항 (의존성 주입)
- 5.4 ExplorerWindow 구조 변경
- 5.5 MainContent 의존성 주입
- 5.6 실행: MainContent 테스트
- 5.7 FolderTreeView 관련 파일 프로젝트 이동
- 5.8 윈도우 디렉터리 구조 만들기
- 5.9 MainContent 뷰모델 구현
- 5.10 MainContet 뷰 구현
- 5.11 ItemsControl: 자식 요소의 객체 지정
- 5.12 뷰모델에서 이벤트를 구현하는 방법
- 5.13 TreeView 이벤트 바인딩
- 5.14 SelectionCommand 연결
- 5.15 실행: SelectionCommand 테스트
- 5.16 좀 더 간소화된 ICommand 만들기
- 5.17 TreeView 계층 구조
- 5.18 TreeViewItem 자식 연결
- 5.19 GetContainerForItem 재정의
- 5.20 계층 표현: DepthConverter
- 5.21 트리 하위 자식 보이기/숨기기 (IsExpanded)
- 5.22 ExpandButton 구현 (ToggleButton)
- 5.23 TreeView 최종 리소스 구현
- 5.24 (MainContent) 세션의 마무리

6. NavigatorService
- 6.1 싱글턴 인스턴스 구현
- 6.2 의존성 주입: NavigatorService 구현
- 6.3 파일 목록 바인딩
- 6.4 FileListBox 구현
- 6.5 상세 파일 목록 만들기
- 6.6 PolygonSelector 구현
- 6.7 (NavigatorService) 섹션의 마무리

7. LocationContent
- 7.1 WpfExplorer.Location
- 7.2 LocationContent 뷰 모듈화
- 7.3 LocatorButton 구현
- 7.4 LocatorTextBox 구현
- 7.5 Generic.xaml 병합하기
- 7.6 LocationContent 뷰 고도화
- 7.7 LocatorTextBox 현재 위치 연결
- 7.8 DarkWindow 고도화
- 7.9 (LocationContent) 섹션의 마무리

8. Advancement
- 8.1 DarkScrollViewer 고도화
- 8.2 FolderTreeView 초기 설정하기
- 8.3 접근 불가능한 디렉터리의 표현
- 8.4 (LocationContent) 섹션의 마무리

## 학습 자료

- [YouTube 실습 영상](https://www.youtube.com/watch?v=2PuvhTEcWAQ)
- [4시간 완전 교육 영상](https://youtube.com/live/KtjC8a-BA1g)

<img src="https://github.com/user-attachments/assets/8e547f5a-762b-43de-81c7-f6f816c9190d" width="49%"/>
<img src="https://github.com/user-attachments/assets/77f1fd54-66f2-46dc-91a2-977d5956c305" width="49%"/>

## 기여하기

이 프로젝트에 기여하고 싶으시다면 풀 리퀘스트를 보내주세요. 모든 기여를 환영합니다!

## 라이선스

이 프로젝트는 MIT 라이선스 하에 있습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 연락처

- 웹사이트: https://jamesnet.dev
- 이메일: james@jamesnet.dev, vickyqu115@hotmail.com
