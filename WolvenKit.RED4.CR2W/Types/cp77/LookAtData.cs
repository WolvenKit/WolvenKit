using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LookAtData : CVariable
	{
		private CInt32 _idle;
		private CInt32 _category;
		private CEnum<gamedataStatType> _personality;

		[Ordinal(0)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get
			{
				if (_idle == null)
				{
					_idle = (CInt32) CR2WTypeManager.Create("Int32", "idle", cr2w, this);
				}
				return _idle;
			}
			set
			{
				if (_idle == value)
				{
					return;
				}
				_idle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("category")] 
		public CInt32 Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CInt32) CR2WTypeManager.Create("Int32", "category", cr2w, this);
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

		[Ordinal(2)] 
		[RED("personality")] 
		public CEnum<gamedataStatType> Personality
		{
			get
			{
				if (_personality == null)
				{
					_personality = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "personality", cr2w, this);
				}
				return _personality;
			}
			set
			{
				if (_personality == value)
				{
					return;
				}
				_personality = value;
				PropertySet(this);
			}
		}

		public LookAtData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
