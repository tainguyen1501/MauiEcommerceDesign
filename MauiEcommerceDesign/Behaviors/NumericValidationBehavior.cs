namespace MauiEcommerceDesign.Behaviors
{
    public class NumericValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Entry)sender).ScaleTo(1, 2000);
            ((Entry)sender).TextColor = ((Entry)sender).Text.Length %2==0 ? Color.Parse("Red") : Color.Parse("Blue");
        }
    }
}
