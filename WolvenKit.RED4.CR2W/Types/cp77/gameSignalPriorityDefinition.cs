using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSignalPriorityDefinition : ISerializable
	{
		private CUInt16 _defaultPriority;

		[Ordinal(0)] 
		[RED("defaultPriority")] 
		public CUInt16 DefaultPriority
		{
			get => GetProperty(ref _defaultPriority);
			set => SetProperty(ref _defaultPriority, value);
		}

		public gameSignalPriorityDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
