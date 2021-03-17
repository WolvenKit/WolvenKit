using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SequenceCallback : redEvent
	{
		private gamePersistentID _persistentID;
		private CName _className;
		private CHandle<ScriptableDeviceAction> _actionToForward;

		[Ordinal(0)] 
		[RED("persistentID")] 
		public gamePersistentID PersistentID
		{
			get => GetProperty(ref _persistentID);
			set => SetProperty(ref _persistentID, value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(2)] 
		[RED("actionToForward")] 
		public CHandle<ScriptableDeviceAction> ActionToForward
		{
			get => GetProperty(ref _actionToForward);
			set => SetProperty(ref _actionToForward, value);
		}

		public SequenceCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
