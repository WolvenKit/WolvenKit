using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCinematicAnimSetSRRef : CVariable
	{
		private raRef<animAnimSet> _asyncAnimSet;
		private CUInt8 _priority;
		private CBool _isOverride;

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

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt8) CR2WTypeManager.Create("Uint8", "priority", cr2w, this);
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

		[Ordinal(2)] 
		[RED("isOverride")] 
		public CBool IsOverride
		{
			get
			{
				if (_isOverride == null)
				{
					_isOverride = (CBool) CR2WTypeManager.Create("Bool", "isOverride", cr2w, this);
				}
				return _isOverride;
			}
			set
			{
				if (_isOverride == value)
				{
					return;
				}
				_isOverride = value;
				PropertySet(this);
			}
		}

		public scnCinematicAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
