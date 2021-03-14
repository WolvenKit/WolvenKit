using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridItem : CVariable
	{
		private CUInt32 _rootIdx;

		[Ordinal(0)] 
		[RED("rootIdx")] 
		public CUInt32 RootIdx
		{
			get
			{
				if (_rootIdx == null)
				{
					_rootIdx = (CUInt32) CR2WTypeManager.Create("Uint32", "rootIdx", cr2w, this);
				}
				return _rootIdx;
			}
			set
			{
				if (_rootIdx == value)
				{
					return;
				}
				_rootIdx = value;
				PropertySet(this);
			}
		}

		public inkGridItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
