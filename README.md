# gmtkGameJam
### 게임 ViViGO
- 요약: Unity, Windows PC 플랫폼의 2D 퍼즐 그리드 기반 게임 개발 프로젝트인 'ViViGO'에 프로그래머로 참여
- 목적: Game Maker's Toolkit 게임잼 2022 출품
- 기간: 2022.07.16 ~ 2022.07.18
- 인원 구성: 기획 1, 프로그래밍 2, 아트 4(프로그래밍으로 참여)
- 주요 업무: [본인 작업 폴더](https://github.com/virtus2/gmtkGameJam/tree/main/Assets/virtus2)와 [ManagerScripts 폴더](https://github.com/virtus2/gmtkGameJam/tree/main/Assets/ManagerScripts)의 일부 C# 스크립트(GameManager의 일부, GameStage, InputManager, PathfindManager) Prefab, 씬 제작
- 상세 업무: 
  - Unity Tilemap 기반의 게임 진행 구현 
    - 빠른 프로토타이핑이 필요한 게임 잼의 특성 상 레벨 디자인의 용이함이 중요할 것이라 생각해 타일맵 사용
    - 타일맵 기반의 그리드와 빈 땅, 벽, 미끄러지는 얼음 등의 타일 기능
    - 레벨을 관리하는 매니저를 만듦. 게임 시작 시 동적으로 모든 레벨을 불러오고 현재 활성화 된 레벨과 타일맵에 따라 오브젝트를 생성해서 게임을 진행
    - 활성화 된 레벨 값만 바꿔주면 에디터에서 쉽게 모든 레벨을 테스트해볼 수 있고, 타일 팔레트를 이용해서 타일만 바꿔 칠해도 레벨 수정이 가능
  - 몬스터 구현
    - BFS 기반의 최단경로 찾기 알고리즘 활용, 턴마다 플레이어를 추격하는 기능
    - 몬스터의 이동 및 애니메이션
    - 제자리에 고정된 몬스터와 상하좌우 1칸씩만 움직이는 몬스터, 총 2종류
  - 플레이어 구현
    - 플레이어 빙판 타일 이동
  - 오브젝트 구현
    - 열쇠로 제거 가능한 자물쇠 오브젝트와 자물쇠를 없앨 수 있는 열쇠 오브젝트
    - 플레이어가 이동 불가능한 장애물 오브젝트
  - UI 구현
    - 게임 씬의 UI 배치

### itch.io 링크(스크린샷 및 실행 가능 버전 포함)
[링크](https://corn97.itch.io/vivigo)
