using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_NewEffect_ReverseFromLastHit : gameEffectPostAction
	{
		private CName _tagInThisFile;
		private CFloat _forwardOffset;
		private CBool _childEffect;
		private CName _childEffectTag;

		[Ordinal(0)] 
		[RED("tagInThisFile")] 
		public CName TagInThisFile
		{
			get
			{
				if (_tagInThisFile == null)
				{
					_tagInThisFile = (CName) CR2WTypeManager.Create("CName", "tagInThisFile", cr2w, this);
				}
				return _tagInThisFile;
			}
			set
			{
				if (_tagInThisFile == value)
				{
					return;
				}
				_tagInThisFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get
			{
				if (_forwardOffset == null)
				{
					_forwardOffset = (CFloat) CR2WTypeManager.Create("Float", "forwardOffset", cr2w, this);
				}
				return _forwardOffset;
			}
			set
			{
				if (_forwardOffset == value)
				{
					return;
				}
				_forwardOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("childEffect")] 
		public CBool ChildEffect
		{
			get
			{
				if (_childEffect == null)
				{
					_childEffect = (CBool) CR2WTypeManager.Create("Bool", "childEffect", cr2w, this);
				}
				return _childEffect;
			}
			set
			{
				if (_childEffect == value)
				{
					return;
				}
				_childEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("childEffectTag")] 
		public CName ChildEffectTag
		{
			get
			{
				if (_childEffectTag == null)
				{
					_childEffectTag = (CName) CR2WTypeManager.Create("CName", "childEffectTag", cr2w, this);
				}
				return _childEffectTag;
			}
			set
			{
				if (_childEffectTag == value)
				{
					return;
				}
				_childEffectTag = value;
				PropertySet(this);
			}
		}

		public gameEffectAction_NewEffect_ReverseFromLastHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
