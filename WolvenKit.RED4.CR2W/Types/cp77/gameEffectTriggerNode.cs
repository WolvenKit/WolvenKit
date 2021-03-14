using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectTriggerNode : worldAreaShapeNode
	{
		private CArray<CHandle<gameEffectTriggerEffectDesc>> _effectDescs;

		[Ordinal(6)] 
		[RED("effectDescs")] 
		public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs
		{
			get
			{
				if (_effectDescs == null)
				{
					_effectDescs = (CArray<CHandle<gameEffectTriggerEffectDesc>>) CR2WTypeManager.Create("array:handle:gameEffectTriggerEffectDesc", "effectDescs", cr2w, this);
				}
				return _effectDescs;
			}
			set
			{
				if (_effectDescs == value)
				{
					return;
				}
				_effectDescs = value;
				PropertySet(this);
			}
		}

		public gameEffectTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
