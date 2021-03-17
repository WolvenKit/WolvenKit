using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThreatPersistanceMemory : CVariable
	{
		private CArray<wCHandle<entEntity>> _threats;
		private CArray<CBool> _isPersistent;

		[Ordinal(0)] 
		[RED("threats")] 
		public CArray<wCHandle<entEntity>> Threats
		{
			get => GetProperty(ref _threats);
			set => SetProperty(ref _threats, value);
		}

		[Ordinal(1)] 
		[RED("isPersistent")] 
		public CArray<CBool> IsPersistent
		{
			get => GetProperty(ref _isPersistent);
			set => SetProperty(ref _isPersistent, value);
		}

		public ThreatPersistanceMemory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
