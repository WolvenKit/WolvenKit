using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectVisualComponentSpawner : effectSpawner
	{
		private CArray<CName> _componentName;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CArray<CName> ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CArray<CName>) CR2WTypeManager.Create("array:CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		public effectVisualComponentSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
