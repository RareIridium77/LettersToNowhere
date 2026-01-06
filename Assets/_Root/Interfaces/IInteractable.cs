
namespace Assets._Root.Interfaces
{
    public enum InteractionType
    {
        User,
        Move,
        // TODO: Inventory
    }

    public interface IInteractable
    {
        public InteractionType InteractionType { get; }

        public void Interact();
    }
}