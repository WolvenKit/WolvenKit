using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimAssistModule : HUDModule
	{
		private CArray<CHandle<AimAssist>> _activeAssists;

		[Ordinal(3)] 
		[RED("activeAssists")] 
		public CArray<CHandle<AimAssist>> ActiveAssists
		{
			get
			{
				if (_activeAssists == null)
				{
					_activeAssists = (CArray<CHandle<AimAssist>>) CR2WTypeManager.Create("array:handle:AimAssist", "activeAssists", cr2w, this);
				}
				return _activeAssists;
			}
			set
			{
				if (_activeAssists == value)
				{
					return;
				}
				_activeAssists = value;
				PropertySet(this);
			}
		}

		public AimAssistModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
