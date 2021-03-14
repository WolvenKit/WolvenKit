using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SVfxInstanceData : CVariable
	{
		private CHandle<gameFxInstance> _fx;
		private CName _id;

		[Ordinal(0)] 
		[RED("fx")] 
		public CHandle<gameFxInstance> Fx
		{
			get
			{
				if (_fx == null)
				{
					_fx = (CHandle<gameFxInstance>) CR2WTypeManager.Create("handle:gameFxInstance", "fx", cr2w, this);
				}
				return _fx;
			}
			set
			{
				if (_fx == value)
				{
					return;
				}
				_fx = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CName Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CName) CR2WTypeManager.Create("CName", "id", cr2w, this);
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

		public SVfxInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
