using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSimpleColliderComponent : entIPlacedComponent
	{
		private CArray<CHandle<physicsICollider>> _colliders;
		private CHandle<physicsFilterData> _filter;
		private DataBuffer _compiledBuffer;

		[Ordinal(5)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get
			{
				if (_colliders == null)
				{
					_colliders = (CArray<CHandle<physicsICollider>>) CR2WTypeManager.Create("array:handle:physicsICollider", "colliders", cr2w, this);
				}
				return _colliders;
			}
			set
			{
				if (_colliders == value)
				{
					return;
				}
				_colliders = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("filter")] 
		public CHandle<physicsFilterData> Filter
		{
			get
			{
				if (_filter == null)
				{
					_filter = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filter", cr2w, this);
				}
				return _filter;
			}
			set
			{
				if (_filter == value)
				{
					return;
				}
				_filter = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("compiledBuffer")] 
		public DataBuffer CompiledBuffer
		{
			get
			{
				if (_compiledBuffer == null)
				{
					_compiledBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "compiledBuffer", cr2w, this);
				}
				return _compiledBuffer;
			}
			set
			{
				if (_compiledBuffer == value)
				{
					return;
				}
				_compiledBuffer = value;
				PropertySet(this);
			}
		}

		public entSimpleColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
