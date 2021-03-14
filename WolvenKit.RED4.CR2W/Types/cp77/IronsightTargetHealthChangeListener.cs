using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IronsightTargetHealthChangeListener : gameScriptStatPoolsListener
	{
		private wCHandle<IronsightGameController> _parentIronsight;

		[Ordinal(0)] 
		[RED("parentIronsight")] 
		public wCHandle<IronsightGameController> ParentIronsight
		{
			get
			{
				if (_parentIronsight == null)
				{
					_parentIronsight = (wCHandle<IronsightGameController>) CR2WTypeManager.Create("whandle:IronsightGameController", "parentIronsight", cr2w, this);
				}
				return _parentIronsight;
			}
			set
			{
				if (_parentIronsight == value)
				{
					return;
				}
				_parentIronsight = value;
				PropertySet(this);
			}
		}

		public IronsightTargetHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
