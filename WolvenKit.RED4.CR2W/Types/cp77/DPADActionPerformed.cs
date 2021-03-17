using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DPADActionPerformed : redEvent
	{
		private entEntityID _ownerID;
		private CEnum<EUIActionState> _state;
		private CInt32 _stateInt;
		private CEnum<gameEHotkey> _action;
		private CBool _successful;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EUIActionState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("stateInt")] 
		public CInt32 StateInt
		{
			get => GetProperty(ref _stateInt);
			set => SetProperty(ref _stateInt, value);
		}

		[Ordinal(3)] 
		[RED("action")] 
		public CEnum<gameEHotkey> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(4)] 
		[RED("successful")] 
		public CBool Successful
		{
			get => GetProperty(ref _successful);
			set => SetProperty(ref _successful, value);
		}

		public DPADActionPerformed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
