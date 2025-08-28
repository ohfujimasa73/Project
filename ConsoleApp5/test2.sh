# 1から5まで数字を順番に表示しながら、各数字を10倍にするコマンドを実行

filename=test.sh
for i in {1..5}; do
	cp ${filename} ${filename}_back
	grep "#" ./${filename}
	rm ${filename}_back
done
