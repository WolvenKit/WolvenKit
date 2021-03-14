using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStaticTriggerAreaComponent : gameStaticAreaShapeComponent
	{
		private CUInt32 _includeMask;
		private CUInt32 _excludeMask;

		[Ordinal(8)] 
		[RED("includeMask")] 
		public CUInt32 IncludeMask
		{
			get
			{
				if (_includeMask == null)
				{
					_includeMask = (CUInt32) CR2WTypeManager.Create("Uint32", "includeMask", cr2w, this);
				}
				return _includeMask;
			}
			set
			{
				if (_includeMask == value)
				{
					return;
				}
				_includeMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("excludeMask")] 
		public CUInt32 ExcludeMask
		{
			get
			{
				if (_excludeMask == null)
				{
					_excludeMask = (CUInt32) CR2WTypeManager.Create("Uint32", "excludeMask", cr2w, this);
				}
				return _excludeMask;
			}
			set
			{
				if (_excludeMask == value)
				{
					return;
				}
				_excludeMask = value;
				PropertySet(this);
			}
		}

		public gameStaticTriggerAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
