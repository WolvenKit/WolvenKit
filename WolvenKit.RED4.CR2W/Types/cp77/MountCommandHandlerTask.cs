using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountCommandHandlerTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _command;
		private CHandle<AIArgumentMapping> _mountEventData;
		private CName _callbackName;

		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<AIArgumentMapping> MountEventData
		{
			get => GetProperty(ref _mountEventData);
			set => SetProperty(ref _mountEventData, value);
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetProperty(ref _callbackName);
			set => SetProperty(ref _callbackName, value);
		}

		public MountCommandHandlerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
