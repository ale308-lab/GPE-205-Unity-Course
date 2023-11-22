public interface IState
{
    void Tick();
    void OnEnter();
    void OnExit();
    // Anything that implements these functions is an IState
  
}
