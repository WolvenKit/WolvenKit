using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_GameObjectOutline : gameEffectExecutor_Scripted
	{
		private CEnum<EOutlineType> _outlineType;

		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get
			{
				if (_outlineType == null)
				{
					_outlineType = (CEnum<EOutlineType>) CR2WTypeManager.Create("EOutlineType", "outlineType", cr2w, this);
				}
				return _outlineType;
			}
			set
			{
				if (_outlineType == value)
				{
					return;
				}
				_outlineType = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_GameObjectOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
