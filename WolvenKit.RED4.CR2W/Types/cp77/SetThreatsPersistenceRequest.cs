using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetThreatsPersistenceRequest : AIAIEvent
	{
		private wCHandle<entEntity> _et;
		private CBool _isPersistent;

		[Ordinal(2)] 
		[RED("et")] 
		public wCHandle<entEntity> Et
		{
			get => GetProperty(ref _et);
			set => SetProperty(ref _et, value);
		}

		[Ordinal(3)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetProperty(ref _isPersistent);
			set => SetProperty(ref _isPersistent, value);
		}

		public SetThreatsPersistenceRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
