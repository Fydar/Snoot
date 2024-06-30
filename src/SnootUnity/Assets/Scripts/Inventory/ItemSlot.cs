using System;

[Serializable]
public class ItemSlot
{
    public Action OnChanged;

    private Item contents;

    public Item Contents
    {
        get => contents;
        set
        {
            contents = value;
            OnChanged?.Invoke();
        }
    }


}
