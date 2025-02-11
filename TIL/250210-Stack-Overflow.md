### 내일배움캠프 13일차 TIL - 무한재귀호출과 스택오버플로우  

~~~C#
public event EventHandler? StateChange;
public bool isHighlighted
{
    get => isHighlighted;
    set
    {
        if (isHighlighted != value)
        {
            isHighlighted = value;
            StateChange?.Invoke(this, EventArgs.Empty);
        }
    }
}
~~~  

스택오버플로우가 일어난다. 외부에서 isHighlighted 의 값을 요청하면 get => isHighlighted, get 이 또 Highlighted 의 값을 달라고 호출....
무한재귀호출이 되어버린다. 그래서 private bool 변수를 하나 두고, 그것의 값을 돌려주게 만들었다.
~~~C#
public event EventHandler? StateChange;
private bool IsHighlighted; //이거 추가하니까 stackoverflow 없어짐
public bool isHighlighted
{
    get => IsHighlighted;
    set
    {
        if (IsHighlighted != value)
        {
            IsHighlighted = value;
            StateChange?.Invoke(this, EventArgs.Empty);
        }
    }
}
~~~  
