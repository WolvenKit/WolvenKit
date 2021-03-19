using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGateSignal : CVariable
	{
		private CStatic<CName> _tags;
		private CEnum<AISignalFlags> _flags;
		private CFloat _priority;
		private CFloat _lifeTime;

		[Ordinal(0)] 
		[RED("tags", 4)] 
		public CStatic<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CEnum<AISignalFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(3)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get => GetProperty(ref _lifeTime);
			set => SetProperty(ref _lifeTime, value);
		}

		public AIGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
