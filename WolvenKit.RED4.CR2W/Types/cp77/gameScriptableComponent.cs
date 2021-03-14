using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScriptableComponent : gameComponent
	{
		private CUInt32 _priority;

		[Ordinal(4)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt32) CR2WTypeManager.Create("Uint32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		public gameScriptableComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
