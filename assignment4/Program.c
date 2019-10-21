/*
    write a program to read N by N elements of matrices A and B
    and then sum together the corresponding elements of the main diagonals 
    of the matrices.
*/

#include <stdio.h>
void main()
{
    static int array[10][10];
    int i, j, m, n, a = 0, sum = 0;

    printf("Enter the order of the matrix \n");
    scanf("%d %d", &m, &n);

    if (m == n)
    {
        printf("Enter the coefficients of the matrix\n");
        for (i = 0; i < m; ++i)
        {
            for (j = 0; j < n; ++j)
            {
                scanf("%d", &array[i][j]);
            }
        }

        printf("The given matrix is \n");
        for (i = 0; i < m; ++i)
        {
            for (j = 0; j < n; ++j)
            {
                printf(" %d", array[i][j]);
            }
            printf("\n");
        }

        for (i = 0; i < m; ++i)
        {
            sum = sum + array[i][i];
            a = a + array[i][m - i - 1];
        }

        printf("\nThe sum of the main diagonal elements is = %d\n", sum);
        printf("The sum of the off diagonal elements is   = %d\n", a);
    }
    else
    {
        printf("Given order not a square matrix\n");
    }
}