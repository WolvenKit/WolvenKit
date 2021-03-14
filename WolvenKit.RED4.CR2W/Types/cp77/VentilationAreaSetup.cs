using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaSetup : CVariable
	{
		private CEnum<ETrapEffects> _areaEffect;
		private CName _actionName;

		[Ordinal(0)] 
		[RED("areaEffect")] 
		public CEnum<ETrapEffects> AreaEffect
		{
			get
			{
				if (_areaEffect == null)
				{
					_areaEffect = (CEnum<ETrapEffects>) CR2WTypeManager.Create("ETrapEffects", "areaEffect", cr2w, this);
				}
				return _areaEffect;
			}
			set
			{
				if (_areaEffect == value)
				{
					return;
				}
				_areaEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		public VentilationAreaSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
