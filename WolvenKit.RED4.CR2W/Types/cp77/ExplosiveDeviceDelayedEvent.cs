using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceDelayedEvent : redEvent
	{
		private CInt32 _arrayIndex;
		private wCHandle<gameObject> _instigator;

		[Ordinal(0)] 
		[RED("arrayIndex")] 
		public CInt32 ArrayIndex
		{
			get => GetProperty(ref _arrayIndex);
			set => SetProperty(ref _arrayIndex, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		public ExplosiveDeviceDelayedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
