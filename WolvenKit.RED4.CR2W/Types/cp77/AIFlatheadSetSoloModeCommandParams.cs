using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFlatheadSetSoloModeCommandParams : questScriptedAICommandParams
	{
		private CBool _soloMode;

		[Ordinal(0)] 
		[RED("soloMode")] 
		public CBool SoloMode
		{
			get
			{
				if (_soloMode == null)
				{
					_soloMode = (CBool) CR2WTypeManager.Create("Bool", "soloMode", cr2w, this);
				}
				return _soloMode;
			}
			set
			{
				if (_soloMode == value)
				{
					return;
				}
				_soloMode = value;
				PropertySet(this);
			}
		}

		public AIFlatheadSetSoloModeCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
