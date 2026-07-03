#!/usr/bin/env python3
"""
compile_changelog.py

Compiles changelog/!unreleased.yaml into:
  1. Appends a new versioned section to changelog.md
  2. Writes current-changelog.md  (Markdown)
  3. Writes current-changelog.txt (BBCode)

Usage:
    python compile_changelog.py --release 1.2.3
    python compile_changelog.py --release 1.2.3 \
        --input changelog/!unreleased.yaml \
        --changelog changelog.md \
        --out-md current-changelog.md \
        --out-bb current-changelog.txt
"""

import argparse
import sys
from collections import defaultdict
from datetime import date
from pathlib import Path

try:
    import yaml
except ImportError:
    sys.exit(
        "PyYAML is required.  Install it with:  pip install pyyaml"
    )

# ── canonical ordering ────────────────────────────────────────────────────────
TYPE_ORDER = ["security", "deprecated", "removed", "added", "fixed", "changed"]

PACKAGE_ORDER = ["App", "CLI", "Nuget Packages"]


# ── helpers ───────────────────────────────────────────────────────────────────

def load_changes(yaml_path: Path) -> list[dict]:
    """Load and validate the unreleased YAML file."""
    with yaml_path.open(encoding="utf-8") as fh:
        data = yaml.safe_load(fh)

    if not data or not isinstance(data, dict):
        sys.exit(f"ERROR: {yaml_path} is empty or not a valid YAML mapping.")

    changes = data.get("changes") or []
    if not changes:
        print(f"WARNING: No changes found in {yaml_path}.  Output files will be empty sections.")
    return changes


def group_changes(changes: list[dict]) -> dict:
    """
    Returns a nested dict:
        { package -> { type -> [ {description, author}, … ] } }
    Entries without a package go under the sentinel key None.
    """
    grouped: dict = defaultdict(lambda: defaultdict(list))

    for entry in changes:
        if not isinstance(entry, dict):
            continue
        entry_type = str(entry.get("type", "")).strip().lower()
        packages   = entry.get("packages") or [None]
        author     = str(entry.get("author", "")).strip()
        description = str(entry.get("description", "")).strip()

        if not description:
            continue

        for pkg in packages:
            pkg_key = str(pkg).strip() if pkg else None
            grouped[pkg_key][entry_type].append(
                {"description": description, "author": author}
            )

    return grouped


def ordered_packages(grouped: dict) -> list:
    """Return packages in canonical order; unknowns appended alphabetically."""
    known   = [p for p in PACKAGE_ORDER if p in grouped]
    unknown = sorted(p for p in grouped if p not in PACKAGE_ORDER and p is not None)
    no_pkg  = [None] if None in grouped else []
    return known + unknown + no_pkg


def ordered_types(type_dict: dict) -> list:
    """Return change types in canonical order; unknowns appended."""
    known   = [t for t in TYPE_ORDER if t in type_dict]
    unknown = sorted(t for t in type_dict if t not in TYPE_ORDER)
    return known + unknown


# ── Markdown builder ──────────────────────────────────────────────────────────

def build_markdown(version: str, grouped: dict) -> str:
    lines = [f"## {version} — {date.today().isoformat()}", ""]

    for pkg in ordered_packages(grouped):
        pkg_label = pkg if pkg else "General"
        lines.append(f"**{pkg_label}**")
        lines.append("")

        for t in ordered_types(grouped[pkg]):
            type_label = t.capitalize()
            for item in grouped[pkg][t]:
                author = item["author"]
                desc   = item["description"]
                bullet = f"* *{type_label}*: {desc}"
                if author:
                    bullet += f" by @{author}"
                lines.append(bullet)

        lines.append("")

    return "\n".join(lines)


# ── BBCode builder ────────────────────────────────────────────────────────────

def build_bbcode(version: str, grouped: dict) -> str:
    lines = [
        f"[b]{version} — {date.today().isoformat()}[/b]",
        ""
    ]

    for pkg in ordered_packages(grouped):
        pkg_label = pkg if pkg else "General"
        lines.append(f"[b]{pkg_label}[/b]")
        lines.append("")

        for t in ordered_types(grouped[pkg]):
            type_label = t.capitalize()
            for item in grouped[pkg][t]:
                author = item["author"]
                desc   = item["description"]
                bullet = f"[*] [i]{type_label}[/i]: {desc}"
                if author:
                    bullet += f" by @{author}"
                lines.append(bullet)

        lines.append("")

    return "\n".join(lines)


# ── file I/O ──────────────────────────────────────────────────────────────────

def prepend_to_changelog(changelog_path: Path, section: str) -> None:
    """Prepend the new version section to the top of changelog.md."""
    existing = ""
    if changelog_path.exists():
        existing = changelog_path.read_text(encoding="utf-8")

    separator = "\n\n---\n\n" if existing.strip() else ""
    changelog_path.write_text(section + separator + existing, encoding="utf-8")
    print(f"  [ok] Updated  {changelog_path}")


def write_file(path: Path, content: str) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(content, encoding="utf-8")
    print(f"  [ok] Wrote    {path}")


# ── CLI ───────────────────────────────────────────────────────────────────────

def parse_args() -> argparse.Namespace:
    p = argparse.ArgumentParser(
        description="Compile changelog/unreleased.yaml into versioned Markdown & BBCode."
    )
    p.add_argument(
        "--release", "-r",
        required=True,
        help="Release version string, e.g. 1.2.3",
    )
    p.add_argument(
        "--input", "-i",
        default="changelog/!unreleased.yaml",
        help="Path to unreleased.yaml  (default: changelog/unreleased.yaml)",
    )
    p.add_argument(
        "--changelog", "-c",
        default="changelog.md",
        help="Path to the running changelog.md  (default: changelog.md)",
    )
    p.add_argument(
        "--out-md",
        default="current-changelog.md",
        help="Output path for current-changelog.md  (default: current-changelog.md)",
    )
    p.add_argument(
        "--out-bb",
        default="current-changelog.txt",
        help="Output path for current-changelog.txt  (default: current-changelog.txt)",
    )
    return p.parse_args()


def main() -> None:
    args = parse_args()

    version = args.release.strip()

    input_path     = Path(args.input)
    changelog_path = Path(args.changelog)
    out_md_path    = Path(args.out_md)
    out_bb_path    = Path(args.out_bb)

    if not input_path.exists():
        sys.exit(f"ERROR: Input file not found: {input_path}")

    print(f"\nCompiling changelog for version {version} …\n")

    changes = load_changes(input_path)
    grouped = group_changes(changes)

    md_section = build_markdown(version, grouped)
    bb_section = build_bbcode(version, grouped)

    prepend_to_changelog(changelog_path, md_section)
    write_file(out_md_path, md_section)
    write_file(out_bb_path, bb_section)

    print("\nDone.")


if __name__ == "__main__":
    main()
