using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDynamicAnimSetSRRef : CVariable
	{
		private raRef<animAnimSet> _asyncAnimSet;

		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public raRef<animAnimSet> AsyncAnimSet
		{
			get
			{
				if (_asyncAnimSet == null)
				{
					_asyncAnimSet = (raRef<animAnimSet>) CR2WTypeManager.Create("raRef:animAnimSet", "asyncAnimSet", cr2w, this);
				}
				return _asyncAnimSet;
			}
			set
			{
				if (_asyncAnimSet == value)
				{
					return;
				}
				_asyncAnimSet = value;
				PropertySet(this);
			}
		}

		public scnDynamicAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
