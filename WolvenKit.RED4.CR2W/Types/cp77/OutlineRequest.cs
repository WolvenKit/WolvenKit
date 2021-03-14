using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineRequest : IScriptable
	{
		private CName _requester;
		private CBool _shouldAdd;
		private CFloat _outlineDuration;
		private OutlineData _outlineData;

		[Ordinal(0)] 
		[RED("requester")] 
		public CName Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (CName) CR2WTypeManager.Create("CName", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get
			{
				if (_shouldAdd == null)
				{
					_shouldAdd = (CBool) CR2WTypeManager.Create("Bool", "shouldAdd", cr2w, this);
				}
				return _shouldAdd;
			}
			set
			{
				if (_shouldAdd == value)
				{
					return;
				}
				_shouldAdd = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outlineDuration")] 
		public CFloat OutlineDuration
		{
			get
			{
				if (_outlineDuration == null)
				{
					_outlineDuration = (CFloat) CR2WTypeManager.Create("Float", "outlineDuration", cr2w, this);
				}
				return _outlineDuration;
			}
			set
			{
				if (_outlineDuration == value)
				{
					return;
				}
				_outlineDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outlineData")] 
		public OutlineData OutlineData
		{
			get
			{
				if (_outlineData == null)
				{
					_outlineData = (OutlineData) CR2WTypeManager.Create("OutlineData", "outlineData", cr2w, this);
				}
				return _outlineData;
			}
			set
			{
				if (_outlineData == value)
				{
					return;
				}
				_outlineData = value;
				PropertySet(this);
			}
		}

		public OutlineRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
