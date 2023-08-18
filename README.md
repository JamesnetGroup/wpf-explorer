# WPF INSIDE OUT - WPF Explorer

<img src="https://github.com/jamesnet214/wpf-explorer/assets/52397976/a27d9634-ca51-4863-ad7d-d290a2fdff96" style="width: 70%"/>


### 실전 프로젝트 소개
WpfExplorer는 WPF (Windows Presentation Foundation)를 깊이 있게 탐구하기 위한 실전 프로젝트입니다. 이 애플리케이션은 윈도우 탐색기의 디렉토리 및 파일 탐색 구조를 반영하여, WPF의 핵심 요소를 체계적으로 이해하는 데 이상적입니다. 여기에는 MVVM 아키텍처, 고급 데이터 바인딩 기술 등 WPF에서의 실무적인 고급 기술들을 전반적으로 다루고 있습니다.

대규모 프로젝트의 관리와 리드에 필요한 세부 기술과 노하우도 집중적으로 다룹니다. 특히, 사용자 지정 컨트롤을 활용한 모듈화된 뷰와 리소스 관리에 대한 실무 지침을 제공하며, ControlTemplate과 트리거를 활용하여 UI/UX 디자인을 효과적으로 제어하는 방법을 소개합니다.
또한, DependencyProperty와 ICommand와 같은 WPF의 고급 바인딩 기술과 이벤트 처리 방법에 대해 깊게 다룹니다. 실무에서 자주 활용되는 ItemsControl, 예를 들면 TreeView와 ListBox와 같은 컨트롤의 활용법과 그로 인한 사용자 경험 향상에 대해 상세하게 설명하고 있습니다. 이를 통해 복잡한 이벤트 관리를 통한 스트레스에서 벗어나 더욱 강력한 MVVM 기술을 구사할 수 있습니다.

마지막으로, WpfExplorer는 단순한 학습 도구를 넘어, WPF의 세계를 체계적으로 탐험하며 실질적인 프로젝트 경험을 제공합니다. 이 프로젝트는 WPF에 대한 깊이 있는 이해와 실무 능력 향상을 목표로 하는 모든 개발자에게 귀중한 자산이 될 수 있도록 세부적인 요소까지 세심하고 의미 있게 구성하였습니다.



### 목차
##### 1.1 학습의 철학과 방향성에 대해

###### 1.1.1 이 책을 통한 학습 방법

###### 1.1.2 실전 프로젝트 소개

###### 1.1.3 애플리케이션의 기술적인 특징 요약

##### 1.2 디자인 요소의 활용과 이해

###### 1.2.1 WPF의 레이아웃 디자인

###### 1.2.2 주요 디자인 속성

###### 1.2.3 색상 표현 (Hexadecimal)

###### 1.2.4 다크 테마 구현

###### 1.2.5 Visibility 속성의 이해

###### 1.2.6 Hexadecimal 투명도와 Opacity의 차이

###### 1.2.7 Geometry를 활용한 이미지 대체와 코드 기반의 디자인 관리

##### 1.3 (CustomControl) 의 전문적인 활용

###### 1.3.1 DefaultStyleKeyProperty를 통한 기본 스타일 연결

###### 1.3.2 스타일 분산화와 병합

###### 1.3.3 폴더 규칙의 통일성과 구조화

##### 1.4 GitHub 레포지터리

##### 1.5 외부 라이브러리와 종속성 관계

###### 1.5.1 Jamesnet.Wpf 라이브러리의 종속성

###### 1.5.2 CommunityToolkit.Mvvm

###### 1.5.3 Prism.Unity

###### 1.5.4 WpfAutoGrid.Core

###### 1.5.5 Jamesnet.Design

##### 1.6 .NET 버전 선택의 중요성

##### 1.7 프로젝트 구성

###### 1.7.1 WpfExplorer

###### 1.7.2 WpfExplorer.Support

###### 1.7.3 WpfExplorer.Forms

###### 1.7.4 WpfExplorer.Main

###### 1.7.5 WpfExplorer.Location

##### 1.8 (Project Overview) 섹션의 마무리



#### Application

---

##### 2.1 프로젝트 네이밍

##### 2.2 새 프로젝트 만들기 (WpfExplorer)

###### 2.2.1 과거와 현재의 크로스플랫폼

##### 2.3 버전 선택 및 프로젝트 만들기

###### 2.3.1 프로젝트 이름을 잘못 지정한 경우

##### 2.4 기본 구성 파일 제거

###### 2.4.1 (Partial) App.g.i.cs 클래스의 자동 생성과 원리

###### 2.4.2 시작 시점의 자동 생성 따른 부작용

##### 2.5 라이브러리와 종속성

###### 2.5.1 Jamesnet.Wpf 설치하기 (NuGet)

###### 2.5.2 Prism 프레임워크

###### 2.5.3 프레임워크, 라이브러리에 종속된 개발에 대해

##### 2.6 App 구현

###### 2.6.1 폐기된 App.xaml 파일 살펴보기

###### 2.6.2 App.cs (파일 생성)

###### 2.6.3 App 상속으로 인한 에러 해결

###### 2.6.4 CreateShell (시작 윈도우 지정하기)

###### 2.6.5 라이브러리 연구 통한 역량 향상

##### 2.7 Starter 구현

###### 2.7.1 Starter.cs (파일 생성)

###### 2.7.2 실행: 결과 확인 테스트

##### 2.8 (Application) 섹션의 마무리



#### 3 DarkWindow

----

##### 3.1 프로젝트 네이밍

##### 3.2 프로젝트 만들기 (WpfExplorer.Support)

###### 3.2.1 닷넷 버전 선택

###### 3.2.2 Jamesnet.Wpf NuGet 설치

###### 3.2.3 NuGet 패키지를 만드는 방법에 대해

###### 3.2.4 프로젝트 생성 확인하기

###### 3.2.5 기본 파일 삭제

##### 3.3 Generic.xaml 관리

###### 3.3.1 불필요한 리소스 제거

##### 3.4 AssemblyInfo.cs 파일과 CustomControl 관계

###### 3.4.1 UserControl과 CustomControl 차이

###### 3.4.2 CustomControl과의 관계

###### 3.4.3 Properties 폴더 생성 AssemblyInfo.cs 파일 이동

##### 3.5 사용자 지정 컨트롤 (CustomControl) 생성

###### 3.5.1 DarkWindow.cs (파일 생성)

###### 3.5.2 상속 클래스 변경하기

###### 3.5.3 윈도우 커스터마이징 이해하기

###### 3.5.4 DarkScrollViewer.cs (파일 생성)

###### 3.5.5 프로젝트 구조 진행 상황 검토

###### 3.5.6 정적 static 생성자의 사용 이유?

##### 3.6 리소스 사전 (ResourceDictionary) 생성

###### 3.6.1 ResourceDictionary 파일 생성

###### 3.6.2 Generic.cxaml 리소스 파일 병합

###### 3.6.3 MergedDictionaries 병합 구조

###### 3.6.4 CustomControl 파일 관리 구조

##### 3.7 윈도우 버튼 구현

###### 3.7.1 버튼 파일 생성 (클래스/리소스사전)

###### 3.7.2 파일 생성 확인

##### 3.8 CloseButton 구현

###### 3.8.1 CloseButton.cs (파일 생성)

###### 3.8.2 CloseButton.xaml (파일 생성)

###### 3.8.3 스타일 키(x:Key)를 지정하지 않는 이유

###### 3.8.4 네임스페이스

###### 3.8.5 JamesIcon 자세히 살펴보기

###### 3.8.6 JamesIcon의 내부 설계 추측하기

###### 3.8.7 외부 라이브러리 분석의 중요성

###### 3.8.8 트리거의 동작 원리 살펴보기

###### 3.8.9 프로퍼티 (Setter) 변경에 대해

##### 3.9 MaximizeButton 구현

###### 3.9.1 MaximizeButton.cs (파일 생성)

###### 3.9.2 MaximizeButton.xaml(파일 생성)

##### 3.10 MinimizeButton 구현

###### 3.10.1 MinimizeButton.cs (파일 생성)

###### 3.10.2 MinimizeButton.xaml(파일 생성)

##### 3.11 Generic.xaml 리소스 파일 병합

##### 3.12 DarkWindow 구현

###### 3.12.1 DarkWindow 고도화

###### 3.12.2 CustomControl 스타일 연결: TargetType

###### 3.12.3 기본 속성 설정

###### 3.12.4 WindowChrome 설정

###### 3.14.5 ControlTemplate 설정

###### 3.14.6 레이아웃 설계

##### 3.13 DarkWindow 실행

###### 3.13.1 프로젝트 참조

###### 3.13.2 CreateShell: 반환 타입 변경

###### 3.13.3 실행: DarkWindow 결과 확인하기

###### 3.13.4 CustomControl 구현 결과

##### 3.14 (Darkwindow) 섹션의 마무리



#### 4 ExplorerWindow

----

##### 4.1 프로젝트 네이밍

##### 4.2 프로젝트 만들기 (WpfExplorer.Forms)

###### 4.2.1 프로젝트 주요 작업 계획

###### 4.2.2 프로젝트 생성 확인하기: WpfExplorer.Forms

###### 4.2.3 기본 파일 삭제

###### 4.2.4 불필요한 리소스 제거

###### 4.2.5 프로젝트 참조: WpfExplorer.Support

###### 4.2.6 DarkWindow를 공용 프로젝트에서 관리하는 이유

###### 4.2.7 Jamesnet.Wpf NuGet 설치

###### 4.2.8 AssemblyInfo.cs 이동

##### 4.3 ExplorerWindow 구현

###### 4.3.1 ExplorerWindow.cs (파일 생성)

###### 4.3.2 DefaultStyleKeyProperty과 BasedOn의 연관관계

###### 4.3.3 ExplorerWindow.xaml (파일 생성)

###### 4.3.4 BasedOn 속성 이해

###### 4.3.5 ControlTemplate를 구현하지 않는 이유이 대해

##### 4.4 ResourceDictionary의 병합

##### 4.5 실행: ExplorerWindow 결과 확인

###### 4.5.1 CustomControl 구현 확인을 위한 체크리스트

###### 4.5.2 프로젝트 참조

###### 4.5.3 CreateShell: 반환 타입 변경 (ExplorerWindow)

###### 4.5.4 실행: ExplorerWindow 결과 확인

##### 4.6 ContentPrsenter 원리 이해하기

###### 4.6.1 Content의 특별한 특성

###### 4.6.2 ContentTemplate 특성

###### 4.6.3 Control과 ContentControl의 차이

##### 4.7 (ExplorerWindow) 섹션의 마무리



#### 5. Multiple ItemsControl

---

##### 5.1 TreeView 구현

###### 5.1.1 윈도우 탐색기 살펴보기

###### 5.1.2 WpfExplorer: TreeView 완성된 모습 미리보기

##### 5.2 FolderTreeView 구현

###### 5.2.1FolderTreeView.cs (파일 생성)

###### 5.2.2 FolderTreeView.xaml (파일 생성)

###### 5.2.3 ResourceDictionary의 병합

###### 5.2.4 로드 시점에 영향 받지 않는 Generic.xaml

###### 5.2.5 로드 시점에 영향을 받지 않는데도 순서배치에 신경쓰는 이유

###### 5.2.6 리소스 순서의 좋은 예, 나쁜 예

##### 5.3 뷰에서 FolderTreeView 추가

###### 5.3.1 ExplorerWindow: FolderTreeView 추가

###### 5.3.2 XAML 네임스페이스 관리 규칙

###### 5.3.3 실행: FolderTreeView 결과 확인

###### 5.3.4 TreeView 임시 데이터 만들기

###### 5.3.5 Template 구현하기

###### 5.3.6 ItemsControl에서 파생된 컨트롤들

###### 5.3.7 실험: BasedOn을 통한 ItemsPresenter 사용하기

###### 5.3.8 원상복구: Template, ItemsPresenter

##### 5.4 FolderTreeItem 구현

###### 5.4.1 FolderTreeItem.cs (파일 생성)

###### 5.4.2 FolderTreeItem.xaml 리소스 생성

##### 5.5 ResourceDictionary의 병합

##### 5.6 실행: FolderTreeItem 테스트

##### 5.7 TreeViewItem 컨트롤 대체하기

###### 5.7.1 실행: FolderTreeItem 대체 확인

###### 5.7.2 스타일에서 폰트 색상(Foreground) 변경하기

###### 5.7.3 DataContext으로 본 DependencnyProperty

###### 5.7.4 실행: 폰트 색상 변경 확인

##### 5.8 MVVM: 뷰모델 구현하기

###### 5.8.1 뷰모델 네이밍에 관하여

###### 5.8.2 ExplorerViewModel.cs (파일 생성)

##### 5.9 바인딩: TestTitle

##### 5.10 DataContext 할당하기

###### 5.10.1 DataContext와 뷰모델 생성의 일관성에 대해

##### 5.11 실행: ViewModel 바인딩 테스트

##### 5.12 임시 속성 제거하기

##### 5.13 또 다른 바인딩 테스트 방법

###### 5.13.1 바인딩을 통한 객체확인 (1)

###### 5.13.2 바인딩을 통한 객체확인 (2)

##### 5.14 모델 클래스 생성

###### 5.14.1 FileInfoBase.cs (파일 생성)

###### 5.14.2 FolderInfo.cs 클래스 생성

##### 5.15 DirectoryManager 클래스 생성 (Helper)

##### 5.16 Prism에 대한 간략한 소개

##### 5.17 싱글턴 객체 등록하기

###### 5.17.1 HelperModules.cs (파일 생성)

###### 5.17.2 HelperModules 모듈 등록하기

##### 5.18 ViewModel 등록 관리

###### 5.18.1 WireDataContext.cs (파일 생성)

###### 5.18.2 WireDataContext 등록하기

###### 5.18.3 기존 DataContext 할당 제거

##### 5.19 의존성 주입

###### 5.19.1 바인딩: DirectoryManagers

###### 5.19.2 실행: 디렉터리 바인딩 테스트

##### 5.20 (Multiple ItemsControl) 섹션의 마무리



#### 6 MainContent

----

##### 6.1 WpfExplorer.Main

###### 6.1.1 프로젝트 생성 확인

###### 6.1.2 프로젝트 준비

###### 6.1.3 MainContent.cs (파일 생성)

###### 6.1.4 ContentControl 사용의 이유

###### 6.1.5 MainContent.xaml (파일 생성)

###### 6.1.6 리소스 병합

##### 6.2 MainContent 등록

###### 6.2.1 ViewModules.cs (파일 생성)

###### 6.2.2 뷰의 싱글턴 등록 방식에 대한 특별한 이유

###### 6.2.3 ViewModules 모듈 등록하기

##### 6.3 객체 설계에 대한 주의 사항 (의존성 주입)

##### 6.4 ExplorerWindow 구조 변경

###### 6.4.1 Region으로 대체

###### 6.4.2 JamesRegion 살펴보기 (오픈소스)

##### 6.5 MainContent 의존성 주입

###### 6.5.1 의존성 주입을 통한 인스턴스 활용 및 캡슐화 이해하기

###### 6.5.2 IViewLoadable 인터페이스의 내부 설계구조

##### 6.6 실행: MainContent 테스트

##### 6.7 FolderTreeView 관련 파일 프로젝트 이동

###### 6.7.1 FolderTreeView.cs (파일 생성)

###### 6.7.2 FolderTreeItem.cs (파일 생성)

###### 6.7.3 FolderTreeView.xaml (파일 생성)

###### 6.7.4 FolderTreeItem.xaml (파일 생성)

###### 6.7.5 Generic.xaml 폐기된 리소스 파일 제거

###### 6.7.6 Generic.xaml 리소스 파일 추가

##### 6.8 윈도우 디렉터리 구조 만들기

###### 6.8.1 FileService.cs (파일 생성)

###### 6.8.2 싱글턴 등록하기

##### 6.9 MainContent 뷰모델 구현

###### 6.9.1 MainContentViewModel.cs (파일 생성)

###### 6.9.2 MainContentViewModel 등록 (WireDataContext)

##### 6.10 MainContet 뷰 구현

###### 6.10.1 FolderTreeView 추가

###### 6.10.2 Roots 바인딩 (ItemsSource)

###### 6.10.3 실행: ItemsSource 바인딩 테스트

##### 6.11 ItemsControl: 자식 요소의 객체 지정

###### 6.11.1 GetContainerForItemOverride

###### 6.11.2 실행: GetContainerForItemOverride 결과 확인하기

###### 6.11.3 훈련: WPF 내부 구현 예측해보기

###### 6.11.4 드라이브에 대한 잡담

##### 6.12 뷰모델에서 이벤트를 구현하는 방법

###### 6.12.1 뷰모델에서 뷰 접근하기

###### 6.12.2 뷰에서 뷰모델 접근하기

##### 6.13 TreeView 이벤트 바인딩

###### 6.13.1 CustomControl 구현

###### 6.13.2 ICommand 바인딩 속성(DependencyProperty) 추가

###### 6.13.3 Selected 이벤트 구현

###### 6.13.4 is 연산자 (키워드)

###### 6.13.5 불완전한 속성: SelectedItem

###### 6.13.6 SelectionCommand Execute (형변환)

##### 6.14 SelectionCommand 연결

###### 6.14.1 뷰모델에서 ICommand 속성 생성

###### 6.14.2 RelayCommand를 생성하여 콜백 메서드 구현

###### 6.14.3 SelectionCommand 바인딩

##### 6.15 실행: SelectionCommand 테스트

##### 6.16 좀 더 간소화된 ICommand 만들기

###### 6.16.1 윈도우 템플릿을 통해 partial 살펴보기

###### 6.16.2 부분(Partial): MainContentViewModel

##### 6.17 TreeView 계층 구조

###### 6.17.1 구현: FolderChanged

###### 6.17.2 구현: RefreshSubdirectories

###### 6.17.3 실행 결과 확인

###### 6.17.4 자식 항목이 보이지 않는 이유

##### 6.18 TreeViewItem 자식 연결

###### 6.18.1 TreeViewItem ItemsSource 바인딩

###### 6.18.2 ItemsPresenter 추가

###### 6.18.3 실행 결과 확인

##### 6.19 GetContainerForItem 재정의

###### 6.19.1 실행 결과 다시 확인

##### 6.20 계층 표현: DepthConverter

###### 6.20.1 DepthConverter.cs (파일 생성)

###### 6.20.2 DepthConverter 적용

###### 6.20.3 실행: DepthConverter

##### 6.21 트리 하위 자식 보이기/숨기기 (IsExpanded)

###### 6.21.1 실행: ItemsPresenter 보이기/숨기기

##### 6.22 ExpandButton 구현 (ToggleButton)

###### 6.22.1 ExpandButton.cs (파일 생성)

###### 6.22.2 ExpandButton.xaml (파일 생성)

###### 6.22.3 Generic.xaml 파일에서 리소스 파일 추가

###### 6.22.4 ExpandButton 추가 및 IsChecked/IsExpanded 동기화

###### 6.22.5 RelativeSource에 대한 이해

###### 6.22.6 IsChecked/IsExpand 독립 및 단방향 동기화

###### 6.22.7 실행: ExpandButton 적용

##### 6.23 TreeView 최종 리소스 구현

###### 6.23.1 TreeViewItem.xaml 고도화

###### 6.23.2 JamesGrid: 행/열 자동 구성

###### 6.23.3 JamesIcon 아이콘과 트리거

###### 6.23.4 실행: FolderTreeItem 기능/디자인 완성

##### 6.24 (MainContent) 세션의 마무리



#### 7 NavigatorService

---

##### 7.1 싱글턴 인스턴스 구현

###### 7.1.1 NavigatorService.cs (파일 생성)

###### 7.1.2 Memento.cs (파일 생성)

###### 7.1.3 이벤트: LocationChangedEventArgs

###### 7.1.4 싱글턴 타입 등록: HelperModules

##### 7.2 의존성 주입: NavigatorService 구현

###### 7.2.1 NavigatorService 로직 추가

##### 7.3 파일 목록 바인딩

###### 7.3.1 Files 리스트 속성 선언 및 초기화

###### 7.3.2 임시 파일 목록 반환 메서드 구현

###### 7.3.3 DataGrid 바인딩: ItemsSource

###### 7.3.4 실행: DataGrid 바인딩 테스트

###### 7.3.5 뷰에서 위치 이동 버튼 추가

###### 7.3.6 뷰모델에서 위치 이동 버튼 Command 구현

###### 7.3.7 실행: 위치 이동 버튼 테스트

##### 7.4 FileListBox 구현

###### 7.4.1 FileListBox.cs (파일 생성)

###### 7.4.2 FileListItem.cs (파일 생성)

###### 7.4.3 GetContainerForItemOverride 자식 요소 지정

###### 7.4.4 FileListBox.xaml (파일 생성)

###### 7.4.5 FileListItem.xaml (파일 생성)

###### 7.4.6 Generic.xaml 리소스 파일 추가

##### 7.5 상세 파일 목록 만들기

###### 7.5.1 FileService 기능 추가: TryRefreshFiles

###### 7.5.2 TryRefreshFiles 메서드로 대체

###### 7.5.3 MainContent: DataGrid 폐기 및 FileListBox 추가

###### 7.5.4 실행: FileListBox 디자인 변경

###### 7.5.5 FileSizeConverter.cs (파일 생성)

###### 7.5.6 FileSizeConverter 적용

###### 7.5.7 실행: FileConverter 적용 확인

##### 7.6 PolygonSelector 구현

###### 7.6.1 PolygonSelector.cs (파일 생성)

###### 7.6.2 PolygonSelectorItem.cs (파일 생성)

###### 7.6.3 PolygonSelector.xaml (파일 생성)

###### 7.6.4 PolygonSelectorItem.xaml (파일 생성)

###### 7.6.5 Generic.xaml

###### 7.6.6 뷰에서 컨트롤 추가

###### 7.6.7 FileService: RefreshLocations 기능 구현

###### 7.6.8 LocationInfo.cs (파일 생성)

###### 7.6.9 ColorManager.cs (파일 생성)

###### 7.6.10 ColorManager 싱글턴 인스턴스 추가하기

###### 7.6.11 뷰모델에서 Locations 컬렉션 선언 및 데이터 채우기

###### 7.6.12 실행: PolygonSelector 결과 확인

##### 7.7 (NavigatorService) 섹션의 마무리



#### 8 LocationContent

---

##### 8.1 WpfExplorer.Location

###### 8.1.1 프로젝트 기본 준비

###### 8.1.2 LocationContent.cs (파일 생성)

###### 8.1.3 LocationContent.xaml (파일 생성)

###### 8.1.4 리소스 병합: LocationContent.xaml

###### 8.1.5 LocationContentViewModel.cs (파일 생성)

##### 8.2 LocationContent 뷰 모듈화

###### 8.2.1 ViewModules: 뷰 등록

###### 8.2.2 WireDataContext: 뷰모델 등록

###### 8.2.3 ExplorerWindow: LocationRegion 추가

###### 8.2.4 Resolve: LocationContent

###### 8.2.5 실행: LocationContent 테스트 및 요약

##### 8.3 LocatorButton 구현

###### 8.3.1 ActionType.cs (파일 생성)

###### 8.3.2 LocatorButton.cs (파일 생성)

###### 8.3.3 LocatorButton.xaml (파일 생성)

##### 8.4 LocatorTextBox 구현

###### 8.4.1 LocatorTextBox.cs (파일 생성)

###### 8.4.2 LocatorTextBox.xaml (파일 생성)

###### 8.4.3 PART_ContentHost 개념 이해하

##### 8.5 Generic.xaml 병합하기

##### 8.6 LocationContent 뷰 고도화

###### 8.6.1 LocationContentViewModel: 기능 구현

###### 8.6.2 실행: LocatorButton 구현 테스트

##### 8.7 LocatorTextBox 현재 위치 연결

###### 8.7.1 LocationContentViewModel: 기능 구현

###### 8.7.2 LocationContent: LocatorTextBox 추가

###### 8.7.3 실행: LocatorTextBox 결과 확인

##### 8.8 DarkWindow 고도화

###### 8.8.1 다중 템플릿을 통한 구조 설계

###### 8.8.2 다중 템플릿 속성 확장하기

###### 8.8.3 다중 템플릿을 통한 리전 재배치

###### 8.8.4 실행: ContentPresenter 확장 및 다중 템플릿 결과 확인

###### 8.8.5 WPF 모든 물질은 Control로 이루어져있다.

##### 8.9 (LocationContent) 섹션의 마무리

#### 9 Advancement
---

##### 9.1 DarkScrollViewer 고도화

###### 9.1.1 ScrollViewer 파트 템플릿(PART_)에 대해

###### 9.1.2 DarkScrollViwer 적용하기: FolderTreeView

###### 9.1.3 DarkScrollViwer 적용하기: FolderTreeView

###### 9.1.4 FileListBox: DarkScrollViwer 추가

###### 9.1.5 실행: DarkScrollViewer 적용 확인

###### 9.1.6 스크롤바의 트렌디한 구현에 대해

##### 9.2 FolderTreeView 초기 설정하기

###### 9.2.1 뷰 로드 시점에서 기본(Default) 항목 선택

##### 9.3 접근 불가능한 디렉터리의 표현

###### 9.3.1 IsDenied 트리거 구현하기

###### 9.3.2 선택된 디렉터리의 접근 권한 체크: IsDenied

###### 9.3.3 실행: IsDenied 데이터 트리거 결과 확인

##### 9.4 (LocationContent) 섹션의 마무리

---

### WPF 스터디 진행중 [[바로가기]] (https://www.youtube.com/watch?v=2PuvhTEcWAQ) 

이번 스터디의 주제는 곧 출시될 WPF 책의 내용을 바탕으로 진행될 예정입니다. 주요 학습 내용은 아래와 같습니다.

- WPF를 이용한 윈도우 탐색기 기능 재현으로 실무 경험 향상
- 다크 테마 기반의 최신 UI/UX 디자인 적용
- StreamGeometry로 일관된 아이콘 표현을 위한 해상도 최적화
- CustomControl로 프로젝트의 모듈화 및 분산화 설계
- .NET Core 종속성 관리 및 이해
- Jamesnet.Wpf 및 기타 라이브러리 사용으로 복잡한 UI 로직 관리
- WireDataContext 및 의존성 주입을 통한 뷰와 뷰모델 관리
- Region을 활용한 뷰의 세분화 및 구조화
- ContentPresenter 확장을 통한 유연한 UI 컴포넌트 구성
- BasedOn 기술을 통한 ControlTemplate 캡슐화
- PART_ 템플릿 파트 규칙을 통한 CustomControl 설계
- Singleton 인스턴스와 의존성 주입으로 코드 효율성 및 재사용성 강화
- Prism 프레임워크의 깊이 있는 이해
- CommunityToolkit.Mvvm 사용으로 MVVM 패턴 생산성 향상
- Multiple ItemsControl 계층적 활용
- WPF의 고급 기능 학습 및 실무 경험 지원
---
<img src="https://github.com/jamesnet214/wpf-explorer/assets/101777355/341dcd46-9db5-422b-816f-cff557c91384" style="width: 30%"/>

### WPF INSIDE OUT 책 구매 [바로가기] (https://jamesnet.dev/books)

---

<img src="https://github.com/jamesnet214/wpf-explorer/assets/101777355/e0e06587-5d9b-4c07-8cbe-7da82efccb99" style="width: 40%"/>

### 유튜브 실습 영상 [[바로가기]] (https://www.youtube.com/watch?v=2PuvhTEcWAQ) 



