using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DPADActionPerformed : redEvent
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EUIActionState> State
		{
			get => GetPropertyValue<CEnum<EUIActionState>>();
			set => SetPropertyValue<CEnum<EUIActionState>>(value);
		}

		[Ordinal(2)] 
		[RED("stateInt")] 
		public CInt32 StateInt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("action")] 
		public CEnum<gameEHotkey> Action
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		[Ordinal(4)] 
		[RED("successful")] 
		public CBool Successful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DPADActionPerformed()
		{
			OwnerID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
