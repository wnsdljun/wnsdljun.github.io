### 내일배움캠프 28일차 TIL - 유니티 인스펙터 창에 필드를 보여주기


#### [SerializeField]
private 로 선언된 필드를 에디터의 인스펙터 창에 보여주는 기능. 지금까지 자주 써 왔었다.  

한편으로는 그런 생각도 들었다. public 으로 선언된 필드는 자동으로 인스펙터에 뜨는데, 이걸 인스펙터에 보여 주지 않을순 없나?

#### [HideInInspector]
public으로 선언된 필드를 인스펙터에서 가리는 기능을 한다.

#### [Range (a, b)]
bool 타입의 변수는 인스펙터에서 체크박스로 표시된다. 이처럼 값을 입력하지 않고 마우스로 조작하는것처럼 슬라이드 바를 조작해 수치를 조정할 수 있다. 코드로 수치를 바꾸는 경우 미리 정해놓은 범위 밖에서도 동작하니 주의가 필요해 보인다.

#### [Header ("string")]
인스펙터에 제목을 넣어준다. 예를들어 플레이어를 구현하는 스크립트라고 했을때, 공격과 관련된 필드, 이동과 관련된 필드 등을 나눠 깔끔하게 보이게 할 수 있다.

이 외에도 엄청나게 많지만 주로 쓰일 것 같은 것만 알아보았다.  
https://docs.unity3d.com/ScriptReference/SerializeReference.html
