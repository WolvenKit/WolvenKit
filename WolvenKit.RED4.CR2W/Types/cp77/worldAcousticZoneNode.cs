using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticZoneNode : worldNode
	{
		private CBool _isBlocker;
		private CName _tagName;
		private CFloat _tagSpread;

		[Ordinal(4)] 
		[RED("isBlocker")] 
		public CBool IsBlocker
		{
			get
			{
				if (_isBlocker == null)
				{
					_isBlocker = (CBool) CR2WTypeManager.Create("Bool", "isBlocker", cr2w, this);
				}
				return _isBlocker;
			}
			set
			{
				if (_isBlocker == value)
				{
					return;
				}
				_isBlocker = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tagName")] 
		public CName TagName
		{
			get
			{
				if (_tagName == null)
				{
					_tagName = (CName) CR2WTypeManager.Create("CName", "tagName", cr2w, this);
				}
				return _tagName;
			}
			set
			{
				if (_tagName == value)
				{
					return;
				}
				_tagName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tagSpread")] 
		public CFloat TagSpread
		{
			get
			{
				if (_tagSpread == null)
				{
					_tagSpread = (CFloat) CR2WTypeManager.Create("Float", "tagSpread", cr2w, this);
				}
				return _tagSpread;
			}
			set
			{
				if (_tagSpread == value)
				{
					return;
				}
				_tagSpread = value;
				PropertySet(this);
			}
		}

		public worldAcousticZoneNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
