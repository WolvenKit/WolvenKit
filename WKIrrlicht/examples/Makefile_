DIRS = $(wildcard [0123]* Demo)

all: $(DIRS)

$(DIRS):
	-@cd $@ && make clean && make

.PHONY: $(DIRS)
