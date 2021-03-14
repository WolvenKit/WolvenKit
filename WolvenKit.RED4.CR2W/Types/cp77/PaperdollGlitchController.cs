using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaperdollGlitchController : inkWidgetLogicController
	{
		private inkWidgetReference _paperdollGlichRoot;
		private CName _glitchAnimationName;

		[Ordinal(1)] 
		[RED("PaperdollGlichRoot")] 
		public inkWidgetReference PaperdollGlichRoot
		{
			get
			{
				if (_paperdollGlichRoot == null)
				{
					_paperdollGlichRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "PaperdollGlichRoot", cr2w, this);
				}
				return _paperdollGlichRoot;
			}
			set
			{
				if (_paperdollGlichRoot == value)
				{
					return;
				}
				_paperdollGlichRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get
			{
				if (_glitchAnimationName == null)
				{
					_glitchAnimationName = (CName) CR2WTypeManager.Create("CName", "GlitchAnimationName", cr2w, this);
				}
				return _glitchAnimationName;
			}
			set
			{
				if (_glitchAnimationName == value)
				{
					return;
				}
				_glitchAnimationName = value;
				PropertySet(this);
			}
		}

		public PaperdollGlitchController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
