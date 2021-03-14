using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_SpawnEffect : gameTransformAnimation_Effects
	{
		private CName _effectName;
		private CName _effectTag;
		private CBool _persistOnDetach;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get
			{
				if (_effectTag == null)
				{
					_effectTag = (CName) CR2WTypeManager.Create("CName", "effectTag", cr2w, this);
				}
				return _effectTag;
			}
			set
			{
				if (_effectTag == value)
				{
					return;
				}
				_effectTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get
			{
				if (_persistOnDetach == null)
				{
					_persistOnDetach = (CBool) CR2WTypeManager.Create("Bool", "persistOnDetach", cr2w, this);
				}
				return _persistOnDetach;
			}
			set
			{
				if (_persistOnDetach == value)
				{
					return;
				}
				_persistOnDetach = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_SpawnEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
