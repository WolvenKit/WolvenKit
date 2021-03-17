using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendSignalTaskDefinition : AIbehaviorTaskDefinition
	{
		private CName _signalName;
		private CEnum<gameBoolSignalAction> _startAction;
		private CHandle<gameSignalUserDataDefinition> _startActionUserData;
		private CEnum<gameBoolSignalAction> _endAction;
		private CHandle<gameSignalUserDataDefinition> _endActionUserData;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(2)] 
		[RED("startAction")] 
		public CEnum<gameBoolSignalAction> StartAction
		{
			get => GetProperty(ref _startAction);
			set => SetProperty(ref _startAction, value);
		}

		[Ordinal(3)] 
		[RED("startActionUserData")] 
		public CHandle<gameSignalUserDataDefinition> StartActionUserData
		{
			get => GetProperty(ref _startActionUserData);
			set => SetProperty(ref _startActionUserData, value);
		}

		[Ordinal(4)] 
		[RED("endAction")] 
		public CEnum<gameBoolSignalAction> EndAction
		{
			get => GetProperty(ref _endAction);
			set => SetProperty(ref _endAction, value);
		}

		[Ordinal(5)] 
		[RED("endActionUserData")] 
		public CHandle<gameSignalUserDataDefinition> EndActionUserData
		{
			get => GetProperty(ref _endActionUserData);
			set => SetProperty(ref _endActionUserData, value);
		}

		public AIbehaviorSendSignalTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
