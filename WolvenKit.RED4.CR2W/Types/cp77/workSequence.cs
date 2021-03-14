using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workSequence : workIContainerEntry
	{
		private CBool _previousLoopInfinitely;
		private CBool _loopInfinitely;
		private CEnum<gamedataWorkspotCategory> _category;

		[Ordinal(4)] 
		[RED("previousLoopInfinitely")] 
		public CBool PreviousLoopInfinitely
		{
			get
			{
				if (_previousLoopInfinitely == null)
				{
					_previousLoopInfinitely = (CBool) CR2WTypeManager.Create("Bool", "previousLoopInfinitely", cr2w, this);
				}
				return _previousLoopInfinitely;
			}
			set
			{
				if (_previousLoopInfinitely == value)
				{
					return;
				}
				_previousLoopInfinitely = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("loopInfinitely")] 
		public CBool LoopInfinitely
		{
			get
			{
				if (_loopInfinitely == null)
				{
					_loopInfinitely = (CBool) CR2WTypeManager.Create("Bool", "loopInfinitely", cr2w, this);
				}
				return _loopInfinitely;
			}
			set
			{
				if (_loopInfinitely == value)
				{
					return;
				}
				_loopInfinitely = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("category")] 
		public CEnum<gamedataWorkspotCategory> Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CEnum<gamedataWorkspotCategory>) CR2WTypeManager.Create("gamedataWorkspotCategory", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		public workSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
