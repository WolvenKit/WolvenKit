using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateSignal : gameTaggedSignalUserData
	{
		private CHandle<AISignalSenderTask> _data;
		private CFloat _priority;
		private CFloat _lifeTime;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<AISignalSenderTask> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
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

		public GateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
