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
			get
			{
				if (_threats == null)
				{
					_threats = (CArray<wCHandle<entEntity>>) CR2WTypeManager.Create("array:whandle:entEntity", "threats", cr2w, this);
				}
				return _threats;
			}
			set
			{
				if (_threats == value)
				{
					return;
				}
				_threats = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPersistent")] 
		public CArray<CBool> IsPersistent
		{
			get
			{
				if (_isPersistent == null)
				{
					_isPersistent = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "isPersistent", cr2w, this);
				}
				return _isPersistent;
			}
			set
			{
				if (_isPersistent == value)
				{
					return;
				}
				_isPersistent = value;
				PropertySet(this);
			}
		}

		public ThreatPersistanceMemory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
