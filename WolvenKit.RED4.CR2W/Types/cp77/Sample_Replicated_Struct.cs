using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Struct : CVariable
	{
		private CBool _a;
		private CBool _b;
		private CBool _c;
		private CBool _d_not_replicated_still_OK;

		[Ordinal(0)] 
		[RED("a")] 
		public CBool A
		{
			get
			{
				if (_a == null)
				{
					_a = (CBool) CR2WTypeManager.Create("Bool", "a", cr2w, this);
				}
				return _a;
			}
			set
			{
				if (_a == value)
				{
					return;
				}
				_a = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CBool B
		{
			get
			{
				if (_b == null)
				{
					_b = (CBool) CR2WTypeManager.Create("Bool", "b", cr2w, this);
				}
				return _b;
			}
			set
			{
				if (_b == value)
				{
					return;
				}
				_b = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("c")] 
		public CBool C
		{
			get
			{
				if (_c == null)
				{
					_c = (CBool) CR2WTypeManager.Create("Bool", "c", cr2w, this);
				}
				return _c;
			}
			set
			{
				if (_c == value)
				{
					return;
				}
				_c = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("d_not_replicated_still_OK")] 
		public CBool D_not_replicated_still_OK
		{
			get
			{
				if (_d_not_replicated_still_OK == null)
				{
					_d_not_replicated_still_OK = (CBool) CR2WTypeManager.Create("Bool", "d_not_replicated_still_OK", cr2w, this);
				}
				return _d_not_replicated_still_OK;
			}
			set
			{
				if (_d_not_replicated_still_OK == value)
				{
					return;
				}
				_d_not_replicated_still_OK = value;
				PropertySet(this);
			}
		}

		public Sample_Replicated_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
