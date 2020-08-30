import math
n = int(input())
xn_list = list(map(int, input().split()))
ans = float('inf')
for i in range(1, 100):
    temp = 0
    for j in xn_list:
        temp += (j-i)**2
    ans = min(ans, temp)
print(ans)