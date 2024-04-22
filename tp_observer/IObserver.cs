/// <summary>
/// Defines a contract for observers that are notified of changes in the subject's state.
/// </summary>
public interface IObserver{
    /// <summary>
    /// Called by the subject to notify the observer of a change in state.
    /// </summary>
    /// <param name="s">The subject whose state has changed.</param>
    void Update(Subject s);
}