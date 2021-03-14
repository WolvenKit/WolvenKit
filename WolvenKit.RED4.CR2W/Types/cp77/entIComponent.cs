using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIComponent : IScriptable
	{
		private CName _name;
		private CBool _isReplicable;
		private CRUID _id;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isReplicable")] 
		public CBool IsReplicable
		{
			get
			{
				if (_isReplicable == null)
				{
					_isReplicable = (CBool) CR2WTypeManager.Create("Bool", "isReplicable", cr2w, this);
				}
				return _isReplicable;
			}
			set
			{
				if (_isReplicable == value)
				{
					return;
				}
				_isReplicable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CRUID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CRUID) CR2WTypeManager.Create("CRUID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public entIComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
