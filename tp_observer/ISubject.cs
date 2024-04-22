/// <summary>
/// Represents a subject that observers can subscribe to for notifications of changes in state.
/// </summary>
public interface ISubject{

    /// <summary>
    /// Gets the current value associated with the subject.
    /// </summary>
    /// <returns>The current value associated with the subject.</returns>
    string GetValue();

    /// <summary>
    /// Sets the current value associated with the subject.
    /// </summary>
    /// <returns></returns>
    void SetValue(string value);

    /// <summary>
    /// Checks if the specified observer is registered with the subject.
    /// </summary>
    /// <param name="o">The observer to check.</param>
    /// <returns>True if the observer is registered with the subject, otherwise false.</returns>
    bool IsRegistered(IObserver o);

    /// <summary>
    /// Registers an observer with the subject to receive notifications.
    /// </summary>
    /// <param name="o">The observer to register.</param>
    void RegisterObserver(IObserver o);
    
    /// <summary>
    /// Unregisters an observer from the subject, stopping it from receiving notifications.
    /// </summary>
    /// <param name="o">The observer to unregister.</param>
    void UnRegisterObserver(IObserver o);
}
