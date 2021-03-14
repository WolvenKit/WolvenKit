using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEffectSpawnerComponent : entIVisualComponent
	{
		private CArray<CHandle<entEffectDesc>> _effectDescs;

		[Ordinal(8)] 
		[RED("effectDescs")] 
		public CArray<CHandle<entEffectDesc>> EffectDescs
		{
			get
			{
				if (_effectDescs == null)
				{
					_effectDescs = (CArray<CHandle<entEffectDesc>>) CR2WTypeManager.Create("array:handle:entEffectDesc", "effectDescs", cr2w, this);
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

		public entEffectSpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
