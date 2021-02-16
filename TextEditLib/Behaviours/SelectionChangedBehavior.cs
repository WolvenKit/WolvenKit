namespace TextEditLib.Behaviors
{
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Controls.Primitives;
	using System.Windows.Input;

	/// <summary>
	/// Attached behaviour to implement a selection changed command on a Selector (combobox).
	/// The Selector (combobox) generates a SelectionChanged event which in turn generates a
	/// Command (in this behavior), which in turn is, when bound, invoked on the viewmodel.
	/// </summary>
	public static class SelectionChangedCommand
	{
		// Field of attached ICommand property
		private static readonly DependencyProperty ChangedCommandProperty = DependencyProperty.RegisterAttached(
			"ChangedCommand",
			typeof(ICommand),
			typeof(SelectionChangedCommand),
			new PropertyMetadata(null, OnSelectionChangedCommandChange));

		/// <summary>
		/// Setter method of the attached DropCommand <seealso cref="ICommand"/> property
		/// </summary>
		/// <param name="source"></param>
		/// <param name="value"></param>
		public static void SetChangedCommand(DependencyObject source, ICommand value)
		{
			source.SetValue(ChangedCommandProperty, value);
		}

		/// <summary>
		/// Getter method of the attached DropCommand <seealso cref="ICommand"/> property
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static ICommand GetChangedCommand(DependencyObject source)
		{
			return (ICommand)source.GetValue(ChangedCommandProperty);
		}

		/// <summary>
		/// This method is hooked in the definition of the <seealso cref="ChangedCommandProperty"/>.
		/// It is called whenever the attached property changes - in our case the event of binding
		/// and unbinding the property to a sink is what we are looking for.
		/// </summary>
		/// <param name="d"></param>
		/// <param name="e"></param>
		private static void OnSelectionChangedCommandChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			Selector uiElement = d as Selector;  // Remove the handler if it exist to avoid memory leaks

			if (uiElement != null)
			{
				uiElement.SelectionChanged -= Selection_Changed;
				uiElement.KeyUp -= uiElement_KeyUp;

				var command = e.NewValue as ICommand;
				if (command != null)
				{
					// the property is attached so we attach the Drop event handler
					uiElement.SelectionChanged += Selection_Changed;
					uiElement.KeyUp += uiElement_KeyUp;
				}
			}
		}

		private static void uiElement_KeyUp(object sender, KeyEventArgs e)
		{
			if (e == null)
				return;

			// Forward key event only if user has hit the return, BackSlash, or Slash key
			if (e.Key != Key.Return)
				return;

			ComboBox uiElement = sender as ComboBox;

			// Sanity check just in case this was somehow send by something else
			if (uiElement == null)
				return;

			ICommand changedCommand = SelectionChangedCommand.GetChangedCommand(uiElement);

			// There may not be a command bound to this after all
			if (changedCommand == null)
				return;

			// Check whether this attached behaviour is bound to a RoutedCommand
			if (changedCommand is RoutedCommand)
			{
				// Execute the routed command
				(changedCommand as RoutedCommand).Execute(uiElement.Text, uiElement);
			}
			else
			{
				// Execute the Command as bound delegate
				changedCommand.Execute(uiElement.Text);
			}
		}

		/// <summary>
		/// This method is called when the selection changed event occurs. The sender should be the control
		/// on which this behaviour is attached - so we convert the sender into a <seealso cref="UIElement"/>
		/// and receive the Command through the <seealso cref="GetChangedCommand"/> getter listed above.
		/// 
		/// This implementation supports binding of delegate commands and routed commands.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void Selection_Changed(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			Selector uiElement = sender as Selector;

			// Sanity check just in case this was somehow send by something else
			if (uiElement == null)
				return;

			ICommand changedCommand = SelectionChangedCommand.GetChangedCommand(uiElement);

			// There may not be a command bound to this after all
			if (changedCommand == null)
				return;

			// Check whether this attached behaviour is bound to a RoutedCommand
			if (changedCommand is RoutedCommand)
			{
				// Execute the routed command
				(changedCommand as RoutedCommand).Execute(e.AddedItems, uiElement);
			}
			else
			{
				// Execute the Command as bound delegate
				changedCommand.Execute(e.AddedItems);
			}
		}
	}
}
